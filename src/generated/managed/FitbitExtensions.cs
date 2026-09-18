//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Fitbit
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class FitbitActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fitbit")]
        public IBodyWorkflowAction<GetSleepGoalResponse> GetSleepGoal([WorkflowExpression] Func<string> userId)
        {
            SourceExpression.Validate(userId, nameof(userId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/1.2/user/{0}/sleep/goal.json", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(userId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<GetSleepGoalResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fitbit")]
        public IBodyWorkflowAction<GetSleepLogbyDateResponse> GetSleepLogbyDate([WorkflowExpression] Func<string> userId, [WorkflowExpression] Func<string> date)
        {
            SourceExpression.Validate(userId, nameof(userId), required: true);
            SourceExpression.Validate(date, nameof(date), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/1.2/user/{0}/sleep/date/{1}.json", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(userId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(date, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<GetSleepLogbyDateResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fitbit")]
        public IBodyWorkflowAction<GetSleepLogbyDateRangeResponse> GetSleepLogbyDateRange([WorkflowExpression] Func<string> userId, [WorkflowExpression] Func<string> startDate, [WorkflowExpression] Func<string> endDate)
        {
            SourceExpression.Validate(userId, nameof(userId), required: true);
            SourceExpression.Validate(startDate, nameof(startDate), required: true);
            SourceExpression.Validate(endDate, nameof(endDate), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/1.2/user/{0}/sleep/date/{1}/{2}.json", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(userId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(startDate, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(endDate, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<GetSleepLogbyDateRangeResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fitbit")]
        public IBodyWorkflowAction<GetSleepLogListResponse> GetSleepLogList([WorkflowExpression] Func<string> userId, [WorkflowExpression] Func<string> afterDate = null, [WorkflowExpression] Func<string> beforeDate = null, [WorkflowExpression] Func<sortInput> sort = null, [WorkflowExpression] Func<int> limit = null)
        {
            SourceExpression.Validate(userId, nameof(userId), required: true);
            SourceExpression.Validate(afterDate, nameof(afterDate), required: false);
            SourceExpression.Validate(beforeDate, nameof(beforeDate), required: false);
            SourceExpression.Validate(sort, nameof(sort), required: false);
            SourceExpression.Validate(limit, nameof(limit), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/1.2/user/{0}/sleep/list.json", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(userId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (afterDate != null)
                    callPayload.Queries["afterDate"] = SourceExpressionConverter.ConvertO(afterDate);
                if (beforeDate != null)
                    callPayload.Queries["beforeDate"] = SourceExpressionConverter.ConvertO(beforeDate);
                if (sort != null)
                    callPayload.Queries["sort"] = SourceExpressionConverter.Convert(sort);
                callPayload.Queries["offset"] = Convert.ToString(0);
                callPayload.Queries["limit"] = Convert.ToString(100);
                if (limit != null)
                    callPayload.Queries["limit"] = SourceExpressionConverter.ConvertO(limit);
                return callPayload;
            }

            return new ApiConnectionAction<GetSleepLogListResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fitbit")]
        public IBodyWorkflowAction<GetActivityGoalsResponse> GetActivityGoals([WorkflowExpression] Func<string> userId, [WorkflowExpression] Func<periodInput> period)
        {
            SourceExpression.Validate(userId, nameof(userId), required: true);
            SourceExpression.Validate(period, nameof(period), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/1/user/{0}/activities/goals/{1}.json", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(userId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(period, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<GetActivityGoalsResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fitbit")]
        public IBodyWorkflowAction<GetActivityLogListResponse> GetActivityLogList([WorkflowExpression] Func<string> userId, [WorkflowExpression] Func<string> afterDate = null, [WorkflowExpression] Func<string> beforeDate = null, [WorkflowExpression] Func<sortInput> sort = null, [WorkflowExpression] Func<int> limit = null)
        {
            SourceExpression.Validate(userId, nameof(userId), required: true);
            SourceExpression.Validate(afterDate, nameof(afterDate), required: false);
            SourceExpression.Validate(beforeDate, nameof(beforeDate), required: false);
            SourceExpression.Validate(sort, nameof(sort), required: false);
            SourceExpression.Validate(limit, nameof(limit), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/1/user/{0}/activities/list.json", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(userId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (afterDate != null)
                    callPayload.Queries["afterDate"] = SourceExpressionConverter.ConvertO(afterDate);
                if (beforeDate != null)
                    callPayload.Queries["beforeDate"] = SourceExpressionConverter.ConvertO(beforeDate);
                if (sort != null)
                    callPayload.Queries["sort"] = SourceExpressionConverter.Convert(sort);
                callPayload.Queries["offset"] = Convert.ToString(0);
                callPayload.Queries["limit"] = Convert.ToString(100);
                if (limit != null)
                    callPayload.Queries["limit"] = SourceExpressionConverter.ConvertO(limit);
                return callPayload;
            }

            return new ApiConnectionAction<GetActivityLogListResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fitbit")]
        public IWorkflowAction GetActivityTCX([WorkflowExpression] Func<string> userId, [WorkflowExpression] Func<string> logId, [WorkflowExpression] Func<bool> includePartialTCX = null)
        {
            SourceExpression.Validate(userId, nameof(userId), required: true);
            SourceExpression.Validate(logId, nameof(logId), required: true);
            SourceExpression.Validate(includePartialTCX, nameof(includePartialTCX), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/1/user/{0}/activities/{1}.tcx", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(userId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(logId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (includePartialTCX != null)
                    callPayload.Queries["includePartialTCX"] = SourceExpressionConverter.ConvertO(includePartialTCX);
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fitbit")]
        public IBodyWorkflowAction<GetAcitivityTypeResponse> GetAcitivityType([WorkflowExpression] Func<string> userId, [WorkflowExpression] Func<string> activityId)
        {
            SourceExpression.Validate(userId, nameof(userId), required: true);
            SourceExpression.Validate(activityId, nameof(activityId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/1/user/{0}/activities/{1}.json", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(userId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(activityId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<GetAcitivityTypeResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fitbit")]
        public IBodyWorkflowAction<GetAllActivityTypesResponse> GetAllActivityTypes()
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/1/activities.json";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<GetAllActivityTypesResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fitbit")]
        public IBodyWorkflowAction<GetDailyActivitySummaryResponse> GetDailyActivitySummary([WorkflowExpression] Func<string> userId, [WorkflowExpression] Func<string> date)
        {
            SourceExpression.Validate(userId, nameof(userId), required: true);
            SourceExpression.Validate(date, nameof(date), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/1/user/{0}/activities/date/{1}.json", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(userId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(date, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<GetDailyActivitySummaryResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fitbit")]
        public IBodyWorkflowAction<GetFavoriteActivitiesResponseItem[]> GetFavoriteActivities([WorkflowExpression] Func<string> userId)
        {
            SourceExpression.Validate(userId, nameof(userId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/1/user/{0}/activities/favorite.json", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(userId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<GetFavoriteActivitiesResponseItem[]>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fitbit")]
        public IBodyWorkflowAction<GetFrequentActivitiesResponseItem[]> GetFrequentActivities([WorkflowExpression] Func<string> userId)
        {
            SourceExpression.Validate(userId, nameof(userId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/1/user/{0}activities/frequent.json", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(userId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<GetFrequentActivitiesResponseItem[]>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fitbit")]
        public IBodyWorkflowAction<GetLifetimeStatsResponse> GetLifetimeStats([WorkflowExpression] Func<string> userId)
        {
            SourceExpression.Validate(userId, nameof(userId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/1/user/{0}/activities.json", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(userId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<GetLifetimeStatsResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fitbit")]
        public IBodyWorkflowAction<GetRecentActivityTypesResponseItem[]> GetRecentActivityTypes([WorkflowExpression] Func<string> userId)
        {
            SourceExpression.Validate(userId, nameof(userId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/1/user/{0}/activities/recent.json", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(userId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<GetRecentActivityTypesResponseItem[]>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fitbit")]
        public IBodyWorkflowAction<GetActivityTimeSeriesbyDateResponse> GetActivityTimeSeriesbyDate([WorkflowExpression] Func<string> userId, [WorkflowExpression] Func<resourceInput> resource, [WorkflowExpression] Func<string> date, [WorkflowExpression] Func<periodInput> period)
        {
            SourceExpression.Validate(userId, nameof(userId), required: true);
            SourceExpression.Validate(resource, nameof(resource), required: true);
            SourceExpression.Validate(date, nameof(date), required: true);
            SourceExpression.Validate(period, nameof(period), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/1/user/{0}/activities/{1}/date/{2}/{3}.json", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(userId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(resource, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(date, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(period, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<GetActivityTimeSeriesbyDateResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fitbit")]
        public IBodyWorkflowAction<GetBodyGoalsResponse> GetBodyGoals([WorkflowExpression] Func<string> userId, [WorkflowExpression] Func<goalTypeInput> goalType)
        {
            SourceExpression.Validate(userId, nameof(userId), required: true);
            SourceExpression.Validate(goalType, nameof(goalType), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/1/user/{0}/body/log/{1}/goal.json", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(userId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(goalType, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<GetBodyGoalsResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fitbit")]
        public IBodyWorkflowAction<GetBodyFattLogResponse> GetBodyFattLog([WorkflowExpression] Func<string> userId, [WorkflowExpression] Func<string> date)
        {
            SourceExpression.Validate(userId, nameof(userId), required: true);
            SourceExpression.Validate(date, nameof(date), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/1/user/{0}/body/log/fat/date/{1}.json", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(userId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(date, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<GetBodyFattLogResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fitbit")]
        public IBodyWorkflowAction<GetWeightLogResponse> GetWeightLog([WorkflowExpression] Func<string> userId, [WorkflowExpression] Func<string> date)
        {
            SourceExpression.Validate(userId, nameof(userId), required: true);
            SourceExpression.Validate(date, nameof(date), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/1/user/{0}/body/log/weight/date/{1}.json", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(userId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(date, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<GetWeightLogResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fitbit")]
        public IBodyWorkflowAction<GetBodyTimeSeriesbyDateResponse> GetBodyTimeSeriesbyDate([WorkflowExpression] Func<string> userId, [WorkflowExpression] Func<resourceInput> resource, [WorkflowExpression] Func<string> date, [WorkflowExpression] Func<periodInput> period)
        {
            SourceExpression.Validate(userId, nameof(userId), required: true);
            SourceExpression.Validate(resource, nameof(resource), required: true);
            SourceExpression.Validate(date, nameof(date), required: true);
            SourceExpression.Validate(period, nameof(period), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/1/user/{0}/body/{1}/date/{2}/{3}.json", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(userId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(resource, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(date, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(period, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<GetBodyTimeSeriesbyDateResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fitbit")]
        public IBodyWorkflowAction<GetBodyFatTimerSeriesbyDateResponse> GetBodyFatTimerSeriesbyDate([WorkflowExpression] Func<string> userId, [WorkflowExpression] Func<string> date, [WorkflowExpression] Func<periodInput> period)
        {
            SourceExpression.Validate(userId, nameof(userId), required: true);
            SourceExpression.Validate(date, nameof(date), required: true);
            SourceExpression.Validate(period, nameof(period), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/1/user/{0}/body/log/fat/date/{1}/{2}.json", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(userId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(date, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(period, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<GetBodyFatTimerSeriesbyDateResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fitbit")]
        public IBodyWorkflowAction<GetWeightTimeSeriesbyDateResponse> GetWeightTimeSeriesbyDate([WorkflowExpression] Func<string> userId, [WorkflowExpression] Func<string> date, [WorkflowExpression] Func<periodInput> period)
        {
            SourceExpression.Validate(userId, nameof(userId), required: true);
            SourceExpression.Validate(date, nameof(date), required: true);
            SourceExpression.Validate(period, nameof(period), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/1/user/{0}/body/log/weight/date/{1}/{2}.json", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(userId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(date, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(period, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<GetWeightTimeSeriesbyDateResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fitbit")]
        public IBodyWorkflowAction<GetBreathingRateSummarybyDateResponse> GetBreathingRateSummarybyDate([WorkflowExpression] Func<string> userId, [WorkflowExpression] Func<string> date)
        {
            SourceExpression.Validate(userId, nameof(userId), required: true);
            SourceExpression.Validate(date, nameof(date), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/1/user/{0}/br/date/{1}.json", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(userId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(date, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<GetBreathingRateSummarybyDateResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fitbit")]
        public IBodyWorkflowAction<GetVO2MaxSummarybyDateResponse> GetVO2MaxSummarybyDate([WorkflowExpression] Func<string> userId, [WorkflowExpression] Func<string> date)
        {
            SourceExpression.Validate(userId, nameof(userId), required: true);
            SourceExpression.Validate(date, nameof(date), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/1/user/{0}/cardioscore/date/{1}.json", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(userId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(date, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<GetVO2MaxSummarybyDateResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fitbit")]
        public IBodyWorkflowAction<GetDevicesResponseItem[]> GetDevices([WorkflowExpression] Func<string> userId)
        {
            SourceExpression.Validate(userId, nameof(userId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/1/user/{0}/devices.json", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(userId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<GetDevicesResponseItem[]>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fitbit")]
        public IBodyWorkflowAction<GetAlarmsResponse> GetAlarms([WorkflowExpression] Func<string> userId, [WorkflowExpression] Func<string> trackerId)
        {
            SourceExpression.Validate(userId, nameof(userId), required: true);
            SourceExpression.Validate(trackerId, nameof(trackerId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/1/user/{0}/devices/tracker/{1}/alarms.json", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(userId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(trackerId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<GetAlarmsResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fitbit")]
        public IBodyWorkflowAction<GetFriendsLeaderboardResponse> GetFriendsLeaderboard([WorkflowExpression] Func<string> userId)
        {
            SourceExpression.Validate(userId, nameof(userId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/1.1/user/{0}/leaderboard/friends.json", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(userId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<GetFriendsLeaderboardResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fitbit")]
        public IBodyWorkflowAction<GetHRVSummarybyDateResponse> GetHRVSummarybyDate([WorkflowExpression] Func<string> userId, [WorkflowExpression] Func<string> date)
        {
            SourceExpression.Validate(userId, nameof(userId), required: true);
            SourceExpression.Validate(date, nameof(date), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/1/user/{0}/hrv/date/{1}.json", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(userId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(date, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<GetHRVSummarybyDateResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fitbit")]
        public IBodyWorkflowAction<GetBadgesResponse> GetBadges([WorkflowExpression] Func<string> userId)
        {
            SourceExpression.Validate(userId, nameof(userId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/1/user/{0}/badges.json", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(userId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<GetBadgesResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fitbit")]
        public IBodyWorkflowAction<GetProfileResponse> GetProfile([WorkflowExpression] Func<string> userId)
        {
            SourceExpression.Validate(userId, nameof(userId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/1/user/{0}/profile.json", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(userId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<GetProfileResponse>(BuildSourceInput);
        }
    }

    public class FitbitTriggers([ConnectionName] string connectionId)
    {
    }

    public class GetSleepGoalResponse
    {
        [JsonProperty("consistency")]
        public GetSleepGoalResponseConsistencyType Consistency { get; set; }

        [JsonProperty("goal")]
        public GetSleepGoalResponseGoalType Goal { get; set; }
    }

    public class GetSleepGoalResponseConsistencyType
    {
        [JsonProperty("flowId")]
        public int FlowId { get; set; }
    }

    public class GetSleepGoalResponseGoalType
    {
        [JsonProperty("minDuration")]
        public int MinDuration { get; set; }

        [JsonProperty("updatedOn")]
        public string UpdatedOn { get; set; }
    }

    public class GetSleepLogbyDateResponse
    {
        [JsonProperty("sleep")]
        public GetSleepLogbyDateResponseSleepTypeItem[] Sleep { get; set; }

        [JsonProperty("summary")]
        public GetSleepLogbyDateResponseSummaryType Summary { get; set; }
    }

    public class GetSleepLogbyDateResponseSleepTypeItem
    {
        [JsonProperty("dateOfSleep")]
        public string DateOfSleep { get; set; }

        [JsonProperty("duration")]
        public int Duration { get; set; }

        [JsonProperty("efficiency")]
        public int Efficiency { get; set; }

        [JsonProperty("endTime")]
        public string EndTime { get; set; }

        [JsonProperty("infoCode")]
        public int InfoCode { get; set; }

        [JsonProperty("isMainSleep")]
        public bool IsMainSleep { get; set; }

        [JsonProperty("levels")]
        public GetSleepLogbyDateResponseSleepTypeItemLevelsType Levels { get; set; }

        [JsonProperty("logId")]
        public int LogId { get; set; }

        [JsonProperty("minutesAfterWakeup")]
        public int MinutesAfterWakeup { get; set; }

        [JsonProperty("minutesAsleep")]
        public int MinutesAsleep { get; set; }

        [JsonProperty("minutesAwake")]
        public int MinutesAwake { get; set; }

        [JsonProperty("minutesToFallAsleep")]
        public int MinutesToFallAsleep { get; set; }

        [JsonProperty("logType")]
        public string LogType { get; set; }

        [JsonProperty("startTime")]
        public string StartTime { get; set; }

        [JsonProperty("timeInBed")]
        public int TimeInBed { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class GetSleepLogbyDateResponseSleepTypeItemLevelsType
    {
        [JsonProperty("data")]
        public GetSleepLogbyDateResponseSleepTypeItemLevelsTypeDataTypeItem[] Data { get; set; }

        [JsonProperty("shortData")]
        public GetSleepLogbyDateResponseSleepTypeItemLevelsTypeShortDataTypeItem[] ShortData { get; set; }

        [JsonProperty("summary")]
        public GetSleepLogbyDateResponseSleepTypeItemLevelsTypeSummaryType Summary { get; set; }
    }

    public class GetSleepLogbyDateResponseSleepTypeItemLevelsTypeDataTypeItem
    {
        [JsonProperty("dateTime")]
        public string DateTime { get; set; }

        [JsonProperty("level")]
        public string Level { get; set; }

        [JsonProperty("seconds")]
        public int Seconds { get; set; }
    }

    public class GetSleepLogbyDateResponseSleepTypeItemLevelsTypeShortDataTypeItem
    {
        [JsonProperty("dateTime")]
        public string DateTime { get; set; }

        [JsonProperty("level")]
        public string Level { get; set; }

        [JsonProperty("seconds")]
        public int Seconds { get; set; }
    }

    public class GetSleepLogbyDateResponseSleepTypeItemLevelsTypeSummaryType
    {
        [JsonProperty("deep")]
        public GetSleepLogbyDateResponseSleepTypeItemLevelsTypeSummaryTypeDeepType Deep { get; set; }

        [JsonProperty("light")]
        public GetSleepLogbyDateResponseSleepTypeItemLevelsTypeSummaryTypeLightType Light { get; set; }

        [JsonProperty("rem")]
        public GetSleepLogbyDateResponseSleepTypeItemLevelsTypeSummaryTypeRemType Rem { get; set; }

        [JsonProperty("wake")]
        public GetSleepLogbyDateResponseSleepTypeItemLevelsTypeSummaryTypeWakeType Wake { get; set; }
    }

    public class GetSleepLogbyDateResponseSleepTypeItemLevelsTypeSummaryTypeDeepType
    {
        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("minutes")]
        public int Minutes { get; set; }

        [JsonProperty("thirtyDayAvgMinutes")]
        public int ThirtyDayAvgMinutes { get; set; }
    }

    public class GetSleepLogbyDateResponseSleepTypeItemLevelsTypeSummaryTypeLightType
    {
        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("minutes")]
        public int Minutes { get; set; }

        [JsonProperty("thirtyDayAvgMinutes")]
        public int ThirtyDayAvgMinutes { get; set; }
    }

    public class GetSleepLogbyDateResponseSleepTypeItemLevelsTypeSummaryTypeRemType
    {
        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("minutes")]
        public int Minutes { get; set; }

        [JsonProperty("thirtyDayAvgMinutes")]
        public int ThirtyDayAvgMinutes { get; set; }
    }

    public class GetSleepLogbyDateResponseSleepTypeItemLevelsTypeSummaryTypeWakeType
    {
        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("minutes")]
        public int Minutes { get; set; }

        [JsonProperty("thirtyDayAvgMinutes")]
        public int ThirtyDayAvgMinutes { get; set; }
    }

    public class GetSleepLogbyDateResponseSummaryType
    {
        [JsonProperty("stages")]
        public GetSleepLogbyDateResponseSummaryTypeStagesType Stages { get; set; }

        [JsonProperty("totalMinutesAsleep")]
        public int TotalMinutesAsleep { get; set; }

        [JsonProperty("totalSleepRecords")]
        public int TotalSleepRecords { get; set; }

        [JsonProperty("totalTimeInBed")]
        public int TotalTimeInBed { get; set; }
    }

    public class GetSleepLogbyDateResponseSummaryTypeStagesType
    {
        [JsonProperty("deep")]
        public int Deep { get; set; }

        [JsonProperty("light")]
        public int Light { get; set; }

        [JsonProperty("rem")]
        public int Rem { get; set; }

        [JsonProperty("wake")]
        public int Wake { get; set; }
    }

    public class GetSleepLogbyDateRangeResponse
    {
        [JsonProperty("sleep")]
        public GetSleepLogbyDateRangeResponseSleepTypeItem[] Sleep { get; set; }
    }

    public class GetSleepLogbyDateRangeResponseSleepTypeItem
    {
        [JsonProperty("dateOfSleep")]
        public string DateOfSleep { get; set; }

        [JsonProperty("duration")]
        public int Duration { get; set; }

        [JsonProperty("efficiency")]
        public int Efficiency { get; set; }

        [JsonProperty("endTime")]
        public string EndTime { get; set; }

        [JsonProperty("infoCode")]
        public int InfoCode { get; set; }

        [JsonProperty("isMainSleep")]
        public bool IsMainSleep { get; set; }

        [JsonProperty("levels")]
        public GetSleepLogbyDateRangeResponseSleepTypeItemLevelsType Levels { get; set; }

        [JsonProperty("logId")]
        public int LogId { get; set; }

        [JsonProperty("minutesAfterWakeup")]
        public int MinutesAfterWakeup { get; set; }

        [JsonProperty("minutesAsleep")]
        public int MinutesAsleep { get; set; }

        [JsonProperty("minutesAwake")]
        public int MinutesAwake { get; set; }

        [JsonProperty("minutesToFallAsleep")]
        public int MinutesToFallAsleep { get; set; }

        [JsonProperty("logType")]
        public string LogType { get; set; }

        [JsonProperty("startTime")]
        public string StartTime { get; set; }

        [JsonProperty("timeInBed")]
        public int TimeInBed { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class GetSleepLogbyDateRangeResponseSleepTypeItemLevelsType
    {
        [JsonProperty("data")]
        public GetSleepLogbyDateRangeResponseSleepTypeItemLevelsTypeDataTypeItem[] Data { get; set; }

        [JsonProperty("summary")]
        public GetSleepLogbyDateRangeResponseSleepTypeItemLevelsTypeSummaryType Summary { get; set; }

        [JsonProperty("shortData")]
        public GetSleepLogbyDateRangeResponseSleepTypeItemLevelsTypeShortDataTypeItem[] ShortData { get; set; }
    }

    public class GetSleepLogbyDateRangeResponseSleepTypeItemLevelsTypeDataTypeItem
    {
        [JsonProperty("dateTime")]
        public string DateTime { get; set; }

        [JsonProperty("level")]
        public string Level { get; set; }

        [JsonProperty("seconds")]
        public int Seconds { get; set; }
    }

    public class GetSleepLogbyDateRangeResponseSleepTypeItemLevelsTypeSummaryType
    {
        [JsonProperty("asleep")]
        public GetSleepLogbyDateRangeResponseSleepTypeItemLevelsTypeSummaryTypeAsleepType Asleep { get; set; }

        [JsonProperty("awake")]
        public GetSleepLogbyDateRangeResponseSleepTypeItemLevelsTypeSummaryTypeAwakeType Awake { get; set; }

        [JsonProperty("restless")]
        public GetSleepLogbyDateRangeResponseSleepTypeItemLevelsTypeSummaryTypeRestlessType Restless { get; set; }

        [JsonProperty("deep")]
        public GetSleepLogbyDateRangeResponseSleepTypeItemLevelsTypeSummaryTypeDeepType Deep { get; set; }

        [JsonProperty("light")]
        public GetSleepLogbyDateRangeResponseSleepTypeItemLevelsTypeSummaryTypeLightType Light { get; set; }

        [JsonProperty("rem")]
        public GetSleepLogbyDateRangeResponseSleepTypeItemLevelsTypeSummaryTypeRemType Rem { get; set; }

        [JsonProperty("wake")]
        public GetSleepLogbyDateRangeResponseSleepTypeItemLevelsTypeSummaryTypeWakeType Wake { get; set; }
    }

    public class GetSleepLogbyDateRangeResponseSleepTypeItemLevelsTypeSummaryTypeAsleepType
    {
        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("minutes")]
        public int Minutes { get; set; }
    }

    public class GetSleepLogbyDateRangeResponseSleepTypeItemLevelsTypeSummaryTypeAwakeType
    {
        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("minutes")]
        public int Minutes { get; set; }
    }

    public class GetSleepLogbyDateRangeResponseSleepTypeItemLevelsTypeSummaryTypeRestlessType
    {
        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("minutes")]
        public int Minutes { get; set; }
    }

    public class GetSleepLogbyDateRangeResponseSleepTypeItemLevelsTypeSummaryTypeDeepType
    {
        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("minutes")]
        public int Minutes { get; set; }

        [JsonProperty("thirtyDayAvgMinutes")]
        public int ThirtyDayAvgMinutes { get; set; }
    }

    public class GetSleepLogbyDateRangeResponseSleepTypeItemLevelsTypeSummaryTypeLightType
    {
        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("minutes")]
        public int Minutes { get; set; }

        [JsonProperty("thirtyDayAvgMinutes")]
        public int ThirtyDayAvgMinutes { get; set; }
    }

    public class GetSleepLogbyDateRangeResponseSleepTypeItemLevelsTypeSummaryTypeRemType
    {
        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("minutes")]
        public int Minutes { get; set; }

        [JsonProperty("thirtyDayAvgMinutes")]
        public int ThirtyDayAvgMinutes { get; set; }
    }

    public class GetSleepLogbyDateRangeResponseSleepTypeItemLevelsTypeSummaryTypeWakeType
    {
        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("minutes")]
        public int Minutes { get; set; }

        [JsonProperty("thirtyDayAvgMinutes")]
        public int ThirtyDayAvgMinutes { get; set; }
    }

    public class GetSleepLogbyDateRangeResponseSleepTypeItemLevelsTypeShortDataTypeItem
    {
        [JsonProperty("dateTime")]
        public string DateTime { get; set; }

        [JsonProperty("level")]
        public string Level { get; set; }

        [JsonProperty("seconds")]
        public int Seconds { get; set; }
    }

    public class GetSleepLogListResponse
    {
        [JsonProperty("pagination")]
        public GetSleepLogListResponsePaginationType Pagination { get; set; }

        [JsonProperty("sleep")]
        public GetSleepLogListResponseSleepTypeItem[] Sleep { get; set; }
    }

    public class GetSleepLogListResponsePaginationType
    {
        [JsonProperty("afterDate")]
        public string AfterDate { get; set; }

        [JsonProperty("limit")]
        public int Limit { get; set; }

        [JsonProperty("next")]
        public string Next { get; set; }

        [JsonProperty("offset")]
        public int Offset { get; set; }

        [JsonProperty("previous")]
        public string Previous { get; set; }

        [JsonProperty("sort")]
        public string Sort { get; set; }
    }

    public class GetSleepLogListResponseSleepTypeItem
    {
        [JsonProperty("dateOfSleep")]
        public string DateOfSleep { get; set; }

        [JsonProperty("duration")]
        public int Duration { get; set; }

        [JsonProperty("efficiency")]
        public int Efficiency { get; set; }

        [JsonProperty("endTime")]
        public string EndTime { get; set; }

        [JsonProperty("infoCode")]
        public int InfoCode { get; set; }

        [JsonProperty("isMainSleep")]
        public bool IsMainSleep { get; set; }

        [JsonProperty("levels")]
        public GetSleepLogListResponseSleepTypeItemLevelsType Levels { get; set; }

        [JsonProperty("logId")]
        public int LogId { get; set; }

        [JsonProperty("logType")]
        public string LogType { get; set; }

        [JsonProperty("minutesAfterWakeup")]
        public int MinutesAfterWakeup { get; set; }

        [JsonProperty("minutesAsleep")]
        public int MinutesAsleep { get; set; }

        [JsonProperty("minutesAwake")]
        public int MinutesAwake { get; set; }

        [JsonProperty("minutesToFallAsleep")]
        public int MinutesToFallAsleep { get; set; }

        [JsonProperty("startTime")]
        public string StartTime { get; set; }

        [JsonProperty("timeInBed")]
        public int TimeInBed { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class GetSleepLogListResponseSleepTypeItemLevelsType
    {
        [JsonProperty("data")]
        public GetSleepLogListResponseSleepTypeItemLevelsTypeDataTypeItem[] Data { get; set; }

        [JsonProperty("shortData")]
        public GetSleepLogListResponseSleepTypeItemLevelsTypeShortDataTypeItem[] ShortData { get; set; }

        [JsonProperty("summary")]
        public GetSleepLogListResponseSleepTypeItemLevelsTypeSummaryType Summary { get; set; }
    }

    public class GetSleepLogListResponseSleepTypeItemLevelsTypeDataTypeItem
    {
        [JsonProperty("dateTime")]
        public string DateTime { get; set; }

        [JsonProperty("level")]
        public string Level { get; set; }

        [JsonProperty("seconds")]
        public int Seconds { get; set; }
    }

    public class GetSleepLogListResponseSleepTypeItemLevelsTypeShortDataTypeItem
    {
        [JsonProperty("dateTime")]
        public string DateTime { get; set; }

        [JsonProperty("level")]
        public string Level { get; set; }

        [JsonProperty("seconds")]
        public int Seconds { get; set; }
    }

    public class GetSleepLogListResponseSleepTypeItemLevelsTypeSummaryType
    {
        [JsonProperty("deep")]
        public GetSleepLogListResponseSleepTypeItemLevelsTypeSummaryTypeDeepType Deep { get; set; }

        [JsonProperty("light")]
        public GetSleepLogListResponseSleepTypeItemLevelsTypeSummaryTypeLightType Light { get; set; }

        [JsonProperty("rem")]
        public GetSleepLogListResponseSleepTypeItemLevelsTypeSummaryTypeRemType Rem { get; set; }

        [JsonProperty("wake")]
        public GetSleepLogListResponseSleepTypeItemLevelsTypeSummaryTypeWakeType Wake { get; set; }
    }

    public class GetSleepLogListResponseSleepTypeItemLevelsTypeSummaryTypeDeepType
    {
        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("minutes")]
        public int Minutes { get; set; }

        [JsonProperty("thirtyDayAvgMinutes")]
        public int ThirtyDayAvgMinutes { get; set; }
    }

    public class GetSleepLogListResponseSleepTypeItemLevelsTypeSummaryTypeLightType
    {
        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("minutes")]
        public int Minutes { get; set; }

        [JsonProperty("thirtyDayAvgMinutes")]
        public int ThirtyDayAvgMinutes { get; set; }
    }

    public class GetSleepLogListResponseSleepTypeItemLevelsTypeSummaryTypeRemType
    {
        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("minutes")]
        public int Minutes { get; set; }

        [JsonProperty("thirtyDayAvgMinutes")]
        public int ThirtyDayAvgMinutes { get; set; }
    }

    public class GetSleepLogListResponseSleepTypeItemLevelsTypeSummaryTypeWakeType
    {
        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("minutes")]
        public int Minutes { get; set; }

        [JsonProperty("thirtyDayAvgMinutes")]
        public int ThirtyDayAvgMinutes { get; set; }
    }

    public enum sortInput
    {
        [EnumMember(Value = "asc")]
        Asc,
        [EnumMember(Value = "desc")]
        Desc
    }

    public class GetActivityGoalsResponse
    {
        [JsonProperty("goals")]
        public GetActivityGoalsResponseGoalsType Goals { get; set; }
    }

    public class GetActivityGoalsResponseGoalsType
    {
        [JsonProperty("activeMinutes")]
        public int ActiveMinutes { get; set; }

        [JsonProperty("activeZoneMinutes")]
        public int ActiveZoneMinutes { get; set; }

        [JsonProperty("caloriesOut")]
        public int CaloriesOut { get; set; }

        [JsonProperty("distance")]
        public double Distance { get; set; }

        [JsonProperty("floors")]
        public int Floors { get; set; }

        [JsonProperty("steps")]
        public int Steps { get; set; }
    }

    public enum periodInput
    {
        [EnumMember(Value = "1d")]
        _1d,
        [EnumMember(Value = "7d")]
        _7d,
        [EnumMember(Value = "30d")]
        _30d,
        [EnumMember(Value = "1w")]
        _1w,
        [EnumMember(Value = "1m")]
        _1m,
        [EnumMember(Value = "3m")]
        _3m,
        [EnumMember(Value = "6m")]
        _6m,
        [EnumMember(Value = "1y")]
        _1y
    }

    public class GetActivityLogListResponse
    {
        [JsonProperty("activities")]
        public GetActivityLogListResponseActivitiesTypeItem[] Activities { get; set; }

        [JsonProperty("pagination")]
        public GetActivityLogListResponsePaginationType Pagination { get; set; }
    }

    public class GetActivityLogListResponseActivitiesTypeItem
    {
        [JsonProperty("activeDuration")]
        public int ActiveDuration { get; set; }

        [JsonProperty("activityLevel")]
        public GetActivityLogListResponseActivitiesTypeItemActivityLevelTypeItem[] ActivityLevel { get; set; }

        [JsonProperty("activityName")]
        public string ActivityName { get; set; }

        [JsonProperty("activityTypeId")]
        public int ActivityTypeId { get; set; }

        [JsonProperty("calories")]
        public int Calories { get; set; }

        [JsonProperty("caloriesLink")]
        public string CaloriesLink { get; set; }

        [JsonProperty("duration")]
        public int Duration { get; set; }

        [JsonProperty("elevationGain")]
        public double ElevationGain { get; set; }

        [JsonProperty("lastModified")]
        public string LastModified { get; set; }

        [JsonProperty("logId")]
        public int LogId { get; set; }

        [JsonProperty("logType")]
        public string LogType { get; set; }

        [JsonProperty("manualValuesSpecified")]
        public GetActivityLogListResponseActivitiesTypeItemManualValuesSpecifiedType ManualValuesSpecified { get; set; }

        [JsonProperty("originalDuration")]
        public int OriginalDuration { get; set; }

        [JsonProperty("originalStartTime")]
        public string OriginalStartTime { get; set; }

        [JsonProperty("startTime")]
        public string StartTime { get; set; }

        [JsonProperty("steps")]
        public int Steps { get; set; }

        [JsonProperty("tcxLink")]
        public string TcxLink { get; set; }
    }

    public class GetActivityLogListResponseActivitiesTypeItemActivityLevelTypeItem
    {
        [JsonProperty("minutes")]
        public int Minutes { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class GetActivityLogListResponseActivitiesTypeItemManualValuesSpecifiedType
    {
        [JsonProperty("calories")]
        public bool Calories { get; set; }

        [JsonProperty("distance")]
        public bool Distance { get; set; }

        [JsonProperty("steps")]
        public bool Steps { get; set; }
    }

    public class GetActivityLogListResponsePaginationType
    {
        [JsonProperty("afterDate")]
        public string AfterDate { get; set; }

        [JsonProperty("limit")]
        public int Limit { get; set; }

        [JsonProperty("next")]
        public string Next { get; set; }

        [JsonProperty("offset")]
        public int Offset { get; set; }

        [JsonProperty("previous")]
        public string Previous { get; set; }

        [JsonProperty("sort")]
        public string Sort { get; set; }
    }

    public class GetAcitivityTypeResponse
    {
        [JsonProperty("activity")]
        public GetAcitivityTypeResponseActivityType Activity { get; set; }
    }

    public class GetAcitivityTypeResponseActivityType
    {
        [JsonProperty("accessLevel")]
        public string AccessLevel { get; set; }

        [JsonProperty("activityLevels")]
        public GetAcitivityTypeResponseActivityTypeActivityLevelsTypeItem[] ActivityLevels { get; set; }

        [JsonProperty("hasSpeed")]
        public bool HasSpeed { get; set; }

        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class GetAcitivityTypeResponseActivityTypeActivityLevelsTypeItem
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("maxSpeedMPH")]
        public double MaxSpeedMPH { get; set; }

        [JsonProperty("mets")]
        public int Mets { get; set; }

        [JsonProperty("minSpeedMPH")]
        public int MinSpeedMPH { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class GetAllActivityTypesResponse
    {
        [JsonProperty("categories")]
        public GetAllActivityTypesResponseCategoriesTypeItem[] Categories { get; set; }
    }

    public class GetAllActivityTypesResponseCategoriesTypeItem
    {
        [JsonProperty("activities")]
        public GetAllActivityTypesResponseCategoriesTypeItemActivitiesTypeItem[] Activities { get; set; }
    }

    public class GetAllActivityTypesResponseCategoriesTypeItemActivitiesTypeItem
    {
        [JsonProperty("accessLevel")]
        public string AccessLevel { get; set; }

        [JsonProperty("activityLevels")]
        public GetAllActivityTypesResponseCategoriesTypeItemActivitiesTypeItemActivityLevelsTypeItem[] ActivityLevels { get; set; }

        [JsonProperty("hasSpeed")]
        public bool HasSpeed { get; set; }

        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("mets")]
        public double Mets { get; set; }
    }

    public class GetAllActivityTypesResponseCategoriesTypeItemActivitiesTypeItemActivityLevelsTypeItem
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("maxSpeedMPH")]
        public int MaxSpeedMPH { get; set; }

        [JsonProperty("mets")]
        public int Mets { get; set; }

        [JsonProperty("minSpeedMPH")]
        public int MinSpeedMPH { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class GetDailyActivitySummaryResponse
    {
        [JsonProperty("activities")]
        public JToken[] Activities { get; set; }

        [JsonProperty("goals")]
        public GetDailyActivitySummaryResponseGoalsType Goals { get; set; }

        [JsonProperty("summary")]
        public GetDailyActivitySummaryResponseSummaryType Summary { get; set; }
    }

    public class GetDailyActivitySummaryResponseGoalsType
    {
        [JsonProperty("activeMinutes")]
        public int ActiveMinutes { get; set; }

        [JsonProperty("caloriesOut")]
        public int CaloriesOut { get; set; }

        [JsonProperty("distance")]
        public double Distance { get; set; }

        [JsonProperty("floors")]
        public int Floors { get; set; }

        [JsonProperty("steps")]
        public int Steps { get; set; }
    }

    public class GetDailyActivitySummaryResponseSummaryType
    {
        [JsonProperty("activeScore")]
        public int ActiveScore { get; set; }

        [JsonProperty("activityCalories")]
        public int ActivityCalories { get; set; }

        [JsonProperty("calorieEstimationMu")]
        public int CalorieEstimationMu { get; set; }

        [JsonProperty("caloriesBMR")]
        public int CaloriesBMR { get; set; }

        [JsonProperty("caloriesOut")]
        public int CaloriesOut { get; set; }

        [JsonProperty("caloriesOutUnestimated")]
        public int CaloriesOutUnestimated { get; set; }

        [JsonProperty("customHeartRateZones")]
        public GetDailyActivitySummaryResponseSummaryTypeCustomHeartRateZonesTypeItem[] CustomHeartRateZones { get; set; }

        [JsonProperty("distances")]
        public GetDailyActivitySummaryResponseSummaryTypeDistancesTypeItem[] Distances { get; set; }

        [JsonProperty("elevation")]
        public int Elevation { get; set; }

        [JsonProperty("fairlyActiveMinutes")]
        public int FairlyActiveMinutes { get; set; }

        [JsonProperty("floors")]
        public int Floors { get; set; }

        [JsonProperty("heartRateZones")]
        public GetDailyActivitySummaryResponseSummaryTypeHeartRateZonesTypeItem[] HeartRateZones { get; set; }

        [JsonProperty("lightlyActiveMinutes")]
        public int LightlyActiveMinutes { get; set; }

        [JsonProperty("marginalCalories")]
        public int MarginalCalories { get; set; }

        [JsonProperty("restingHeartRate")]
        public int RestingHeartRate { get; set; }

        [JsonProperty("sedentaryMinutes")]
        public int SedentaryMinutes { get; set; }

        [JsonProperty("steps")]
        public int Steps { get; set; }

        [JsonProperty("useEstimation")]
        public bool UseEstimation { get; set; }

        [JsonProperty("veryActiveMinutes")]
        public int VeryActiveMinutes { get; set; }
    }

    public class GetDailyActivitySummaryResponseSummaryTypeCustomHeartRateZonesTypeItem
    {
        [JsonProperty("caloriesOut")]
        public int CaloriesOut { get; set; }

        [JsonProperty("max")]
        public int Max { get; set; }

        [JsonProperty("min")]
        public int Min { get; set; }

        [JsonProperty("minutes")]
        public int Minutes { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class GetDailyActivitySummaryResponseSummaryTypeDistancesTypeItem
    {
        [JsonProperty("activity")]
        public string Activity { get; set; }

        [JsonProperty("distance")]
        public int Distance { get; set; }
    }

    public class GetDailyActivitySummaryResponseSummaryTypeHeartRateZonesTypeItem
    {
        [JsonProperty("caloriesOut")]
        public int CaloriesOut { get; set; }

        [JsonProperty("max")]
        public int Max { get; set; }

        [JsonProperty("min")]
        public int Min { get; set; }

        [JsonProperty("minutes")]
        public int Minutes { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class GetFavoriteActivitiesResponseItem
    {
        [JsonProperty("activityId")]
        public int ActivityId { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("mets")]
        public int Mets { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class GetFrequentActivitiesResponseItem
    {
        [JsonProperty("activityId")]
        public int ActivityId { get; set; }

        [JsonProperty("calories")]
        public int Calories { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("distance")]
        public int Distance { get; set; }

        [JsonProperty("duration")]
        public int Duration { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class GetLifetimeStatsResponse
    {
        [JsonProperty("best")]
        public GetLifetimeStatsResponseBestType Best { get; set; }

        [JsonProperty("lifetime")]
        public GetLifetimeStatsResponseLifetimeType Lifetime { get; set; }
    }

    public class GetLifetimeStatsResponseBestType
    {
        [JsonProperty("total")]
        public GetLifetimeStatsResponseBestTypeTotalType Total { get; set; }

        [JsonProperty("tracker")]
        public GetLifetimeStatsResponseBestTypeTrackerType Tracker { get; set; }
    }

    public class GetLifetimeStatsResponseBestTypeTotalType
    {
        [JsonProperty("distance")]
        public GetLifetimeStatsResponseBestTypeTotalTypeDistanceType Distance { get; set; }

        [JsonProperty("floors")]
        public GetLifetimeStatsResponseBestTypeTotalTypeFloorsType Floors { get; set; }

        [JsonProperty("steps")]
        public GetLifetimeStatsResponseBestTypeTotalTypeStepsType Steps { get; set; }
    }

    public class GetLifetimeStatsResponseBestTypeTotalTypeDistanceType
    {
        [JsonProperty("date")]
        public string Date { get; set; }

        [JsonProperty("value")]
        public double Value { get; set; }
    }

    public class GetLifetimeStatsResponseBestTypeTotalTypeFloorsType
    {
        [JsonProperty("date")]
        public string Date { get; set; }

        [JsonProperty("value")]
        public double Value { get; set; }
    }

    public class GetLifetimeStatsResponseBestTypeTotalTypeStepsType
    {
        [JsonProperty("date")]
        public string Date { get; set; }

        [JsonProperty("value")]
        public int Value { get; set; }
    }

    public class GetLifetimeStatsResponseBestTypeTrackerType
    {
        [JsonProperty("distance")]
        public GetLifetimeStatsResponseBestTypeTrackerTypeDistanceType Distance { get; set; }

        [JsonProperty("floors")]
        public GetLifetimeStatsResponseBestTypeTrackerTypeFloorsType Floors { get; set; }

        [JsonProperty("steps")]
        public GetLifetimeStatsResponseBestTypeTrackerTypeStepsType Steps { get; set; }
    }

    public class GetLifetimeStatsResponseBestTypeTrackerTypeDistanceType
    {
        [JsonProperty("date")]
        public string Date { get; set; }

        [JsonProperty("value")]
        public double Value { get; set; }
    }

    public class GetLifetimeStatsResponseBestTypeTrackerTypeFloorsType
    {
        [JsonProperty("date")]
        public string Date { get; set; }

        [JsonProperty("value")]
        public double Value { get; set; }
    }

    public class GetLifetimeStatsResponseBestTypeTrackerTypeStepsType
    {
        [JsonProperty("date")]
        public string Date { get; set; }

        [JsonProperty("value")]
        public int Value { get; set; }
    }

    public class GetLifetimeStatsResponseLifetimeType
    {
        [JsonProperty("total")]
        public GetLifetimeStatsResponseLifetimeTypeTotalType Total { get; set; }

        [JsonProperty("tracker")]
        public GetLifetimeStatsResponseLifetimeTypeTrackerType Tracker { get; set; }
    }

    public class GetLifetimeStatsResponseLifetimeTypeTotalType
    {
        [JsonProperty("activeScore")]
        public int ActiveScore { get; set; }

        [JsonProperty("caloriesOut")]
        public int CaloriesOut { get; set; }

        [JsonProperty("distance")]
        public double Distance { get; set; }

        [JsonProperty("floors")]
        public int Floors { get; set; }

        [JsonProperty("steps")]
        public int Steps { get; set; }
    }

    public class GetLifetimeStatsResponseLifetimeTypeTrackerType
    {
        [JsonProperty("activeScore")]
        public int ActiveScore { get; set; }

        [JsonProperty("caloriesOut")]
        public int CaloriesOut { get; set; }

        [JsonProperty("distance")]
        public double Distance { get; set; }

        [JsonProperty("floors")]
        public int Floors { get; set; }

        [JsonProperty("steps")]
        public int Steps { get; set; }
    }

    public class GetRecentActivityTypesResponseItem
    {
        [JsonProperty("activityId")]
        public int ActivityId { get; set; }

        [JsonProperty("calories")]
        public int Calories { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("distance")]
        public int Distance { get; set; }

        [JsonProperty("duration")]
        public int Duration { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class GetActivityTimeSeriesbyDateResponse
    {
        [JsonProperty("activities-steps")]
        public GetActivityTimeSeriesbyDateResponseActivitiesStepsTypeItem[] ActivitiesSteps { get; set; }
    }

    public class GetActivityTimeSeriesbyDateResponseActivitiesStepsTypeItem
    {
        [JsonProperty("dateTime")]
        public string DateTime { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public enum resourceInput
    {
        [EnumMember(Value = "bmi")]
        Bmi,
        [EnumMember(Value = "fat")]
        Fat,
        [EnumMember(Value = "weight")]
        Weight
    }

    public class GetBodyGoalsResponse
    {
        [JsonProperty("goal")]
        public GetBodyGoalsResponseGoalType Goal { get; set; }
    }

    public class GetBodyGoalsResponseGoalType
    {
        [JsonProperty("goalType")]
        public string GoalType { get; set; }

        [JsonProperty("startDate")]
        public string StartDate { get; set; }

        [JsonProperty("startWeight")]
        public double StartWeight { get; set; }

        [JsonProperty("weight")]
        public double Weight { get; set; }

        [JsonProperty("weightThreshold")]
        public double WeightThreshold { get; set; }
    }

    public enum goalTypeInput
    {
        [EnumMember(Value = "weight")]
        Weight,
        [EnumMember(Value = "fat")]
        Fat
    }

    public class GetBodyFattLogResponse
    {
        [JsonProperty("fat")]
        public GetBodyFattLogResponseFatTypeItem[] Fat { get; set; }
    }

    public class GetBodyFattLogResponseFatTypeItem
    {
        [JsonProperty("date")]
        public string Date { get; set; }

        [JsonProperty("fat")]
        public int Fat { get; set; }

        [JsonProperty("logId")]
        public int LogId { get; set; }

        [JsonProperty("source")]
        public string Source { get; set; }

        [JsonProperty("time")]
        public string Time { get; set; }
    }

    public class GetWeightLogResponse
    {
        [JsonProperty("weight")]
        public GetWeightLogResponseWeightTypeItem[] Weight { get; set; }
    }

    public class GetWeightLogResponseWeightTypeItem
    {
        [JsonProperty("bmi")]
        public double Bmi { get; set; }

        [JsonProperty("date")]
        public string Date { get; set; }

        [JsonProperty("fat")]
        public int Fat { get; set; }

        [JsonProperty("logId")]
        public int LogId { get; set; }

        [JsonProperty("source")]
        public string Source { get; set; }

        [JsonProperty("time")]
        public string Time { get; set; }

        [JsonProperty("weight")]
        public int Weight { get; set; }
    }

    public class GetBodyTimeSeriesbyDateResponse
    {
        [JsonProperty("body-weight")]
        public GetBodyTimeSeriesbyDateResponseBodyWeightTypeItem[] BodyWeight { get; set; }
    }

    public class GetBodyTimeSeriesbyDateResponseBodyWeightTypeItem
    {
        [JsonProperty("dateTime")]
        public string DateTime { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class GetBodyFatTimerSeriesbyDateResponse
    {
        [JsonProperty("fat")]
        public GetBodyFatTimerSeriesbyDateResponseFatTypeItem[] Fat { get; set; }
    }

    public class GetBodyFatTimerSeriesbyDateResponseFatTypeItem
    {
        [JsonProperty("date")]
        public string Date { get; set; }

        [JsonProperty("fat")]
        public double Fat { get; set; }

        [JsonProperty("logId")]
        public int LogId { get; set; }

        [JsonProperty("source")]
        public string Source { get; set; }

        [JsonProperty("time")]
        public string Time { get; set; }
    }

    public class GetWeightTimeSeriesbyDateResponse
    {
        [JsonProperty("weight")]
        public GetWeightTimeSeriesbyDateResponseWeightTypeItem[] Weight { get; set; }
    }

    public class GetWeightTimeSeriesbyDateResponseWeightTypeItem
    {
        [JsonProperty("bmi")]
        public double Bmi { get; set; }

        [JsonProperty("date")]
        public string Date { get; set; }

        [JsonProperty("fat")]
        public int Fat { get; set; }

        [JsonProperty("logId")]
        public int LogId { get; set; }

        [JsonProperty("source")]
        public string Source { get; set; }

        [JsonProperty("time")]
        public string Time { get; set; }

        [JsonProperty("weight")]
        public int Weight { get; set; }
    }

    public class GetBreathingRateSummarybyDateResponse
    {
        [JsonProperty("br")]
        public GetBreathingRateSummarybyDateResponseBrTypeItem[] Br { get; set; }
    }

    public class GetBreathingRateSummarybyDateResponseBrTypeItem
    {
        [JsonProperty("value")]
        public GetBreathingRateSummarybyDateResponseBrTypeItemValueType Value { get; set; }

        [JsonProperty("dateTime")]
        public string DateTime { get; set; }
    }

    public class GetBreathingRateSummarybyDateResponseBrTypeItemValueType
    {
        [JsonProperty("breathingRate")]
        public double BreathingRate { get; set; }
    }

    public class GetVO2MaxSummarybyDateResponse
    {
        [JsonProperty("cardioScore")]
        public GetVO2MaxSummarybyDateResponseCardioScoreTypeItem[] CardioScore { get; set; }
    }

    public class GetVO2MaxSummarybyDateResponseCardioScoreTypeItem
    {
        [JsonProperty("dateTime")]
        public string DateTime { get; set; }

        [JsonProperty("value")]
        public GetVO2MaxSummarybyDateResponseCardioScoreTypeItemValueType Value { get; set; }
    }

    public class GetVO2MaxSummarybyDateResponseCardioScoreTypeItemValueType
    {
        [JsonProperty("vo2Max")]
        public string Vo2Max { get; set; }
    }

    public class GetDevicesResponseItem
    {
        [JsonProperty("battery")]
        public string Battery { get; set; }

        [JsonProperty("batteryLevel")]
        public int BatteryLevel { get; set; }

        [JsonProperty("deviceVersion")]
        public string DeviceVersion { get; set; }

        [JsonProperty("features")]
        public JToken[] Features { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("lastSyncTime")]
        public string LastSyncTime { get; set; }

        [JsonProperty("mac")]
        public string Mac { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class GetAlarmsResponse
    {
        [JsonProperty("trackerAlarms")]
        public GetAlarmsResponseTrackerAlarmsTypeItem[] TrackerAlarms { get; set; }
    }

    public class GetAlarmsResponseTrackerAlarmsTypeItem
    {
        [JsonProperty("alarmId")]
        public int AlarmId { get; set; }

        [JsonProperty("deleted")]
        public bool Deleted { get; set; }

        [JsonProperty("enabled")]
        public bool Enabled { get; set; }

        [JsonProperty("recurring")]
        public bool Recurring { get; set; }

        [JsonProperty("snoozeCount")]
        public int SnoozeCount { get; set; }

        [JsonProperty("snoozeLength")]
        public int SnoozeLength { get; set; }

        [JsonProperty("syncedToDevice")]
        public bool SyncedToDevice { get; set; }

        [JsonProperty("time")]
        public string Time { get; set; }

        [JsonProperty("vibe")]
        public string Vibe { get; set; }

        [JsonProperty("weekDays")]
        public string[] WeekDays { get; set; }
    }

    public class GetFriendsLeaderboardResponse
    {
        [JsonProperty("data")]
        public GetFriendsLeaderboardResponseDataTypeItem[] Data { get; set; }

        [JsonProperty("included")]
        public GetFriendsLeaderboardResponseIncludedTypeItem[] Included { get; set; }
    }

    public class GetFriendsLeaderboardResponseDataTypeItem
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("attributes")]
        public GetFriendsLeaderboardResponseDataTypeItemAttributesType Attributes { get; set; }

        [JsonProperty("relationships")]
        public GetFriendsLeaderboardResponseDataTypeItemRelationshipsType Relationships { get; set; }
    }

    public class GetFriendsLeaderboardResponseDataTypeItemAttributesType
    {
        [JsonProperty("step-rank")]
        public int StepRank { get; set; }

        [JsonProperty("step-summary")]
        public int StepSummary { get; set; }
    }

    public class GetFriendsLeaderboardResponseDataTypeItemRelationshipsType
    {
        [JsonProperty("user")]
        public GetFriendsLeaderboardResponseDataTypeItemRelationshipsTypeUserType User { get; set; }
    }

    public class GetFriendsLeaderboardResponseDataTypeItemRelationshipsTypeUserType
    {
        [JsonProperty("data")]
        public GetFriendsLeaderboardResponseDataTypeItemRelationshipsTypeUserTypeDataType Data { get; set; }
    }

    public class GetFriendsLeaderboardResponseDataTypeItemRelationshipsTypeUserTypeDataType
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class GetFriendsLeaderboardResponseIncludedTypeItem
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("attributes")]
        public GetFriendsLeaderboardResponseIncludedTypeItemAttributesType Attributes { get; set; }
    }

    public class GetFriendsLeaderboardResponseIncludedTypeItemAttributesType
    {
        [JsonProperty("avatar")]
        public string Avatar { get; set; }

        [JsonProperty("child")]
        public bool Child { get; set; }

        [JsonProperty("friend")]
        public bool Friend { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class GetHRVSummarybyDateResponse
    {
        [JsonProperty("hrv")]
        public GetHRVSummarybyDateResponseHrvTypeItem[] Hrv { get; set; }
    }

    public class GetHRVSummarybyDateResponseHrvTypeItem
    {
        [JsonProperty("value")]
        public GetHRVSummarybyDateResponseHrvTypeItemValueType Value { get; set; }

        [JsonProperty("dateTime")]
        public string DateTime { get; set; }
    }

    public class GetHRVSummarybyDateResponseHrvTypeItemValueType
    {
        [JsonProperty("dailyRmssd")]
        public double DailyRmssd { get; set; }

        [JsonProperty("deepRmssd")]
        public double DeepRmssd { get; set; }
    }

    public class GetBadgesResponse
    {
        [JsonProperty("badges")]
        public GetBadgesResponseBadgesTypeItem[] Badges { get; set; }
    }

    public class GetBadgesResponseBadgesTypeItem
    {
        [JsonProperty("badgeGradientEndColor")]
        public string BadgeGradientEndColor { get; set; }

        [JsonProperty("badgeGradientStartColor")]
        public string BadgeGradientStartColor { get; set; }

        [JsonProperty("badgeType")]
        public string BadgeType { get; set; }

        [JsonProperty("category")]
        public string Category { get; set; }

        [JsonProperty("cheers")]
        public JToken[] Cheers { get; set; }

        [JsonProperty("dateTime")]
        public string DateTime { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("earnedMessage")]
        public string EarnedMessage { get; set; }

        [JsonProperty("encodedId")]
        public string EncodedId { get; set; }

        [JsonProperty("image100px")]
        public string Image100px { get; set; }

        [JsonProperty("image125px")]
        public string Image125px { get; set; }

        [JsonProperty("image300px")]
        public string Image300px { get; set; }

        [JsonProperty("image50px")]
        public string Image50px { get; set; }

        [JsonProperty("image75px")]
        public string Image75px { get; set; }

        [JsonProperty("marketingDescription")]
        public string MarketingDescription { get; set; }

        [JsonProperty("mobileDescription")]
        public string MobileDescription { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("shareImage640px")]
        public string ShareImage640px { get; set; }

        [JsonProperty("shareText")]
        public string ShareText { get; set; }

        [JsonProperty("shortDescription")]
        public string ShortDescription { get; set; }

        [JsonProperty("shortName")]
        public string ShortName { get; set; }

        [JsonProperty("timesAchieved")]
        public int TimesAchieved { get; set; }

        [JsonProperty("value")]
        public int Value { get; set; }
    }

    public class GetProfileResponse
    {
        [JsonProperty("user")]
        public GetProfileResponseUserType User { get; set; }
    }

    public class GetProfileResponseUserType
    {
        [JsonProperty("aboutMe")]
        public string AboutMe { get; set; }

        [JsonProperty("age")]
        public string Age { get; set; }

        [JsonProperty("ambassador")]
        public string Ambassador { get; set; }

        [JsonProperty("autoStrideEnabled")]
        public string AutoStrideEnabled { get; set; }

        [JsonProperty("avatar")]
        public string Avatar { get; set; }

        [JsonProperty("avatar150")]
        public string Avatar150 { get; set; }

        [JsonProperty("avatar640")]
        public string Avatar640 { get; set; }

        [JsonProperty("averageDailySteps")]
        public string AverageDailySteps { get; set; }

        [JsonProperty("challengesBeta")]
        public string ChallengesBeta { get; set; }

        [JsonProperty("clockTimeDisplayFormat")]
        public string ClockTimeDisplayFormat { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("corporate")]
        public string Corporate { get; set; }

        [JsonProperty("corporateAdmin")]
        public string CorporateAdmin { get; set; }

        [JsonProperty("dateOfBirth")]
        public string DateOfBirth { get; set; }

        [JsonProperty("displayName")]
        public string DisplayName { get; set; }

        [JsonProperty("displayNameSetting")]
        public string DisplayNameSetting { get; set; }

        [JsonProperty("distanceUnit")]
        public string DistanceUnit { get; set; }

        [JsonProperty("encodedId")]
        public string EncodedId { get; set; }

        [JsonProperty("features")]
        public GetProfileResponseUserTypeFeaturesType Features { get; set; }

        [JsonProperty("firstName")]
        public string FirstName { get; set; }

        [JsonProperty("foodsLocale")]
        public string FoodsLocale { get; set; }

        [JsonProperty("fullName")]
        public string FullName { get; set; }

        [JsonProperty("gender")]
        public string Gender { get; set; }

        [JsonProperty("glucoseUnit")]
        public string GlucoseUnit { get; set; }

        [JsonProperty("height")]
        public string Height { get; set; }

        [JsonProperty("heightUnit")]
        public string HeightUnit { get; set; }

        [JsonProperty("isBugReportEnabled")]
        public string IsBugReportEnabled { get; set; }

        [JsonProperty("isChild")]
        public string IsChild { get; set; }

        [JsonProperty("isCoach")]
        public string IsCoach { get; set; }

        [JsonProperty("languageLocale")]
        public string LanguageLocale { get; set; }

        [JsonProperty("lastName")]
        public string LastName { get; set; }

        [JsonProperty("legalTermsAcceptRequired")]
        public string LegalTermsAcceptRequired { get; set; }

        [JsonProperty("locale")]
        public string Locale { get; set; }

        [JsonProperty("memberSince")]
        public string MemberSince { get; set; }

        [JsonProperty("mfaEnabled")]
        public string MfaEnabled { get; set; }

        [JsonProperty("offsetFromUTCMillis")]
        public string OffsetFromUTCMillis { get; set; }

        [JsonProperty("sdkDeveloper")]
        public string SdkDeveloper { get; set; }

        [JsonProperty("sleepTracking")]
        public string SleepTracking { get; set; }

        [JsonProperty("startDayOfWeek")]
        public string StartDayOfWeek { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("strideLengthRunning")]
        public string StrideLengthRunning { get; set; }

        [JsonProperty("strideLengthRunningType")]
        public string StrideLengthRunningType { get; set; }

        [JsonProperty("strideLengthWalking")]
        public string StrideLengthWalking { get; set; }

        [JsonProperty("strideLengthWalkingType")]
        public string StrideLengthWalkingType { get; set; }

        [JsonProperty("swimUnit")]
        public string SwimUnit { get; set; }

        [JsonProperty("temperatureUnit")]
        public string TemperatureUnit { get; set; }

        [JsonProperty("timezone")]
        public string Timezone { get; set; }

        [JsonProperty("topBadges")]
        public string TopBadges { get; set; }

        [JsonProperty("waterUnit")]
        public string WaterUnit { get; set; }

        [JsonProperty("waterUnitName")]
        public string WaterUnitName { get; set; }

        [JsonProperty("weight")]
        public string Weight { get; set; }

        [JsonProperty("weightUnit")]
        public string WeightUnit { get; set; }
    }

    public class GetProfileResponseUserTypeFeaturesType
    {
        [JsonProperty("exerciseGoal")]
        public string ExerciseGoal { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Fitbit;

    public partial class WorkflowManagedActions
    {
        public FitbitActions Fitbit(string connectionId) => new FitbitActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public FitbitTriggers Fitbit(string connectionId) => new FitbitTriggers(connectionId);
    }
}