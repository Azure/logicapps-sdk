//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Workingdaysip
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class WorkingdaysipActions([ConnectionName] string connectionId)
    {

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workingdaysip")]
        [WorkflowExpressionFactory(nameof(__BuildAddWorkingDays))]
        public IBodyWorkflowAction<AddWorkingDaysResponse> AddWorkingDays([WorkflowExpression] Func<countryCodeInput> countryCode, [WorkflowExpression] Func<string> startDate, [WorkflowExpression] Func<string> increment, [WorkflowExpression] Func<bool> includeStart, [WorkflowExpression] Func<string> configuration = null, [WorkflowExpression] Func<string> weekend = null, [WorkflowExpression] Func<string> weekTimes = null, [WorkflowExpression] Func<string> startTemplate = null, [WorkflowExpression] Func<bool> useCustomConfiguration = null, [WorkflowExpression] Func<string> profileId = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workingdaysip")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<AddWorkingDaysResponse> __BuildAddWorkingDays(WorkflowExpression<countryCodeInput> countryCode, WorkflowExpression<string> startDate, WorkflowExpression<string> increment, WorkflowExpression<bool> includeStart, WorkflowExpression<string> configuration = null, WorkflowExpression<string> weekend = null, WorkflowExpression<string> weekTimes = null, WorkflowExpression<string> startTemplate = null, WorkflowExpression<bool> useCustomConfiguration = null, WorkflowExpression<string> profileId = null)
        {
            WorkflowExpression.Validate(countryCode, nameof(countryCode), required: true);
            WorkflowExpression.Validate(startDate, nameof(startDate), required: true);
            WorkflowExpression.Validate(increment, nameof(increment), required: true);
            WorkflowExpression.Validate(includeStart, nameof(includeStart), required: true);
            WorkflowExpression.Validate(configuration, nameof(configuration), required: false);
            WorkflowExpression.Validate(weekend, nameof(weekend), required: false);
            WorkflowExpression.Validate(weekTimes, nameof(weekTimes), required: false);
            WorkflowExpression.Validate(startTemplate, nameof(startTemplate), required: false);
            WorkflowExpression.Validate(useCustomConfiguration, nameof(useCustomConfiguration), required: false);
            WorkflowExpression.Validate(profileId, nameof(profileId), required: false);
            return new DeferredBodyAction<AddWorkingDaysResponse>(() =>
            {
                var apiCallPath = "/1.2/add_working_days";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["country_code"] = ExpressionConverter.Convert(countryCode);
                callPayload.Queries["start_date"] = ExpressionConverter.Convert(startDate);
                callPayload.Queries["increment"] = ExpressionConverter.Convert(increment);
                callPayload.Queries["include_start"] = ExpressionConverter.Convert(includeStart);
                callPayload.Queries["configuration"] = Convert.ToString("Federal holidays");
                if (configuration != null)
                    callPayload.Queries["configuration"] = ExpressionConverter.Convert(configuration);
                callPayload.Queries["weekend"] = Convert.ToString("1000001");
                if (weekend != null)
                    callPayload.Queries["weekend"] = ExpressionConverter.Convert(weekend);
                callPayload.Queries["week_times"] = Convert.ToString("08:00*12:00*14:00*18:00*08:00*12:00*14:00*18:00*08:00*12:00*14:00*18:00*08:00*12:00*14:00*18:00*08:00*12:00*14:00*18:00*08:00*12:00*14:00*18:00*08:00*12:00*14:00*18:00*");
                if (weekTimes != null)
                    callPayload.Queries["week_times"] = ExpressionConverter.Convert(weekTimes);
                if (startTemplate != null)
                    callPayload.Queries["start_template"] = ExpressionConverter.Convert(startTemplate);
                callPayload.Queries["use_custom_configuration"] = Convert.ToString(false);
                if (useCustomConfiguration != null)
                    callPayload.Queries["use_custom_configuration"] = ExpressionConverter.Convert(useCustomConfiguration);
                callPayload.Queries["profile_id"] = Convert.ToString("ut");
                if (profileId != null)
                    callPayload.Queries["profile_id"] = ExpressionConverter.Convert(profileId);
                callPayload.Headers["Accept"] = Convert.ToString("application/json; charset=utf-8");
                return new ApiConnectionAction<AddWorkingDaysResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workingdaysip")]
        [WorkflowExpressionFactory(nameof(__BuildAnalyze))]
        public IBodyWorkflowAction<AnalyzeResponse> Analyze([WorkflowExpression] Func<countryCodeInput> countryCode, [WorkflowExpression] Func<string> startDate, [WorkflowExpression] Func<string> endDate, [WorkflowExpression] Func<string> startTime = null, [WorkflowExpression] Func<string> endTime = null, [WorkflowExpression] Func<string> configuration = null, [WorkflowExpression] Func<string> weekend = null, [WorkflowExpression] Func<string> weekTimes = null, [WorkflowExpression] Func<string> startTemplate = null, [WorkflowExpression] Func<bool> useCustomConfiguration = null, [WorkflowExpression] Func<string> profileId = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workingdaysip")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<AnalyzeResponse> __BuildAnalyze(WorkflowExpression<countryCodeInput> countryCode, WorkflowExpression<string> startDate, WorkflowExpression<string> endDate, WorkflowExpression<string> startTime = null, WorkflowExpression<string> endTime = null, WorkflowExpression<string> configuration = null, WorkflowExpression<string> weekend = null, WorkflowExpression<string> weekTimes = null, WorkflowExpression<string> startTemplate = null, WorkflowExpression<bool> useCustomConfiguration = null, WorkflowExpression<string> profileId = null)
        {
            WorkflowExpression.Validate(countryCode, nameof(countryCode), required: true);
            WorkflowExpression.Validate(startDate, nameof(startDate), required: true);
            WorkflowExpression.Validate(endDate, nameof(endDate), required: true);
            WorkflowExpression.Validate(startTime, nameof(startTime), required: false);
            WorkflowExpression.Validate(endTime, nameof(endTime), required: false);
            WorkflowExpression.Validate(configuration, nameof(configuration), required: false);
            WorkflowExpression.Validate(weekend, nameof(weekend), required: false);
            WorkflowExpression.Validate(weekTimes, nameof(weekTimes), required: false);
            WorkflowExpression.Validate(startTemplate, nameof(startTemplate), required: false);
            WorkflowExpression.Validate(useCustomConfiguration, nameof(useCustomConfiguration), required: false);
            WorkflowExpression.Validate(profileId, nameof(profileId), required: false);
            return new DeferredBodyAction<AnalyzeResponse>(() =>
            {
                var apiCallPath = "/1.2/analyse";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["country_code"] = ExpressionConverter.Convert(countryCode);
                callPayload.Queries["start_date"] = ExpressionConverter.Convert(startDate);
                callPayload.Queries["end_date"] = ExpressionConverter.Convert(endDate);
                if (startTime != null)
                    callPayload.Queries["start_time"] = ExpressionConverter.Convert(startTime);
                if (endTime != null)
                    callPayload.Queries["end_time"] = ExpressionConverter.Convert(endTime);
                callPayload.Queries["configuration"] = Convert.ToString("Federal holidays");
                if (configuration != null)
                    callPayload.Queries["configuration"] = ExpressionConverter.Convert(configuration);
                callPayload.Queries["weekend"] = Convert.ToString("1000001");
                if (weekend != null)
                    callPayload.Queries["weekend"] = ExpressionConverter.Convert(weekend);
                callPayload.Queries["week_times"] = Convert.ToString("08:00*12:00*14:00*18:00*08:00*12:00*14:00*18:00*08:00*12:00*14:00*18:00*08:00*12:00*14:00*18:00*08:00*12:00*14:00*18:00*08:00*12:00*14:00*18:00*08:00*12:00*14:00*18:00*");
                if (weekTimes != null)
                    callPayload.Queries["week_times"] = ExpressionConverter.Convert(weekTimes);
                if (startTemplate != null)
                    callPayload.Queries["start_template"] = ExpressionConverter.Convert(startTemplate);
                callPayload.Queries["use_custom_configuration"] = Convert.ToString(false);
                if (useCustomConfiguration != null)
                    callPayload.Queries["use_custom_configuration"] = ExpressionConverter.Convert(useCustomConfiguration);
                callPayload.Queries["profile_id"] = Convert.ToString("ut");
                if (profileId != null)
                    callPayload.Queries["profile_id"] = ExpressionConverter.Convert(profileId);
                callPayload.Headers["Accept"] = Convert.ToString("application/json; charset=utf-8");
                return new ApiConnectionAction<AnalyzeResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workingdaysip")]
        [WorkflowExpressionFactory(nameof(__BuildGetInfoDay))]
        public IBodyWorkflowAction<GetInfoDayResponse> GetInfoDay([WorkflowExpression] Func<countryCodeInput> countryCode, [WorkflowExpression] Func<string> date, [WorkflowExpression] Func<string> configuration = null, [WorkflowExpression] Func<string> weekend = null, [WorkflowExpression] Func<bool> useCustomConfiguration = null, [WorkflowExpression] Func<string> profileId = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workingdaysip")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GetInfoDayResponse> __BuildGetInfoDay(WorkflowExpression<countryCodeInput> countryCode, WorkflowExpression<string> date, WorkflowExpression<string> configuration = null, WorkflowExpression<string> weekend = null, WorkflowExpression<bool> useCustomConfiguration = null, WorkflowExpression<string> profileId = null)
        {
            WorkflowExpression.Validate(countryCode, nameof(countryCode), required: true);
            WorkflowExpression.Validate(date, nameof(date), required: true);
            WorkflowExpression.Validate(configuration, nameof(configuration), required: false);
            WorkflowExpression.Validate(weekend, nameof(weekend), required: false);
            WorkflowExpression.Validate(useCustomConfiguration, nameof(useCustomConfiguration), required: false);
            WorkflowExpression.Validate(profileId, nameof(profileId), required: false);
            return new DeferredBodyAction<GetInfoDayResponse>(() =>
            {
                var apiCallPath = "/1.2/get_info_day";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["country_code"] = ExpressionConverter.Convert(countryCode);
                callPayload.Queries["date"] = ExpressionConverter.Convert(date);
                callPayload.Queries["configuration"] = Convert.ToString("Federal holidays");
                if (configuration != null)
                    callPayload.Queries["configuration"] = ExpressionConverter.Convert(configuration);
                callPayload.Queries["weekend"] = Convert.ToString("1000001");
                if (weekend != null)
                    callPayload.Queries["weekend"] = ExpressionConverter.Convert(weekend);
                callPayload.Queries["use_custom_configuration"] = Convert.ToString(false);
                if (useCustomConfiguration != null)
                    callPayload.Queries["use_custom_configuration"] = ExpressionConverter.Convert(useCustomConfiguration);
                callPayload.Queries["profile_id"] = Convert.ToString("ut");
                if (profileId != null)
                    callPayload.Queries["profile_id"] = ExpressionConverter.Convert(profileId);
                callPayload.Headers["Accept"] = Convert.ToString("application/json; charset=utf-8");
                return new ApiConnectionAction<GetInfoDayResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workingdaysip")]
        [WorkflowExpressionFactory(nameof(__BuildListNonWorkingDays))]
        public IBodyWorkflowAction<ListNonWorkingDaysResponse> ListNonWorkingDays([WorkflowExpression] Func<countryCodeInput> countryCode, [WorkflowExpression] Func<string> startDate, [WorkflowExpression] Func<string> endDate, [WorkflowExpression] Func<string> configuration = null, [WorkflowExpression] Func<string> weekend = null, [WorkflowExpression] Func<bool> useCustomConfiguration = null, [WorkflowExpression] Func<string> profileId = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workingdaysip")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ListNonWorkingDaysResponse> __BuildListNonWorkingDays(WorkflowExpression<countryCodeInput> countryCode, WorkflowExpression<string> startDate, WorkflowExpression<string> endDate, WorkflowExpression<string> configuration = null, WorkflowExpression<string> weekend = null, WorkflowExpression<bool> useCustomConfiguration = null, WorkflowExpression<string> profileId = null)
        {
            WorkflowExpression.Validate(countryCode, nameof(countryCode), required: true);
            WorkflowExpression.Validate(startDate, nameof(startDate), required: true);
            WorkflowExpression.Validate(endDate, nameof(endDate), required: true);
            WorkflowExpression.Validate(configuration, nameof(configuration), required: false);
            WorkflowExpression.Validate(weekend, nameof(weekend), required: false);
            WorkflowExpression.Validate(useCustomConfiguration, nameof(useCustomConfiguration), required: false);
            WorkflowExpression.Validate(profileId, nameof(profileId), required: false);
            return new DeferredBodyAction<ListNonWorkingDaysResponse>(() =>
            {
                var apiCallPath = "/1.2/list_non_working_days";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["country_code"] = ExpressionConverter.Convert(countryCode);
                callPayload.Queries["start_date"] = ExpressionConverter.Convert(startDate);
                callPayload.Queries["end_date"] = ExpressionConverter.Convert(endDate);
                callPayload.Queries["configuration"] = Convert.ToString("Federal holidays");
                if (configuration != null)
                    callPayload.Queries["configuration"] = ExpressionConverter.Convert(configuration);
                callPayload.Queries["weekend"] = Convert.ToString("1000001");
                if (weekend != null)
                    callPayload.Queries["weekend"] = ExpressionConverter.Convert(weekend);
                callPayload.Queries["use_custom_configuration"] = Convert.ToString(false);
                if (useCustomConfiguration != null)
                    callPayload.Queries["use_custom_configuration"] = ExpressionConverter.Convert(useCustomConfiguration);
                callPayload.Queries["profile_id"] = Convert.ToString("ut");
                if (profileId != null)
                    callPayload.Queries["profile_id"] = ExpressionConverter.Convert(profileId);
                callPayload.Headers["Accept"] = Convert.ToString("application/json; charset=utf-8");
                return new ApiConnectionAction<ListNonWorkingDaysResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workingdaysip")]
        [WorkflowExpressionFactory(nameof(__BuildAddWorkingHours))]
        public IBodyWorkflowAction<AddWorkingHoursResponse> AddWorkingHours([WorkflowExpression] Func<countryCodeInput> countryCode, [WorkflowExpression] Func<string> startDate, [WorkflowExpression] Func<string> startTime, [WorkflowExpression] Func<string> incrementTime, [WorkflowExpression] Func<string> configuration = null, [WorkflowExpression] Func<string> weekend = null, [WorkflowExpression] Func<string> weekTimes = null, [WorkflowExpression] Func<string> startTemplate = null, [WorkflowExpression] Func<bool> useCustomConfiguration = null, [WorkflowExpression] Func<string> profileId = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workingdaysip")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<AddWorkingHoursResponse> __BuildAddWorkingHours(WorkflowExpression<countryCodeInput> countryCode, WorkflowExpression<string> startDate, WorkflowExpression<string> startTime, WorkflowExpression<string> incrementTime, WorkflowExpression<string> configuration = null, WorkflowExpression<string> weekend = null, WorkflowExpression<string> weekTimes = null, WorkflowExpression<string> startTemplate = null, WorkflowExpression<bool> useCustomConfiguration = null, WorkflowExpression<string> profileId = null)
        {
            WorkflowExpression.Validate(countryCode, nameof(countryCode), required: true);
            WorkflowExpression.Validate(startDate, nameof(startDate), required: true);
            WorkflowExpression.Validate(startTime, nameof(startTime), required: true);
            WorkflowExpression.Validate(incrementTime, nameof(incrementTime), required: true);
            WorkflowExpression.Validate(configuration, nameof(configuration), required: false);
            WorkflowExpression.Validate(weekend, nameof(weekend), required: false);
            WorkflowExpression.Validate(weekTimes, nameof(weekTimes), required: false);
            WorkflowExpression.Validate(startTemplate, nameof(startTemplate), required: false);
            WorkflowExpression.Validate(useCustomConfiguration, nameof(useCustomConfiguration), required: false);
            WorkflowExpression.Validate(profileId, nameof(profileId), required: false);
            return new DeferredBodyAction<AddWorkingHoursResponse>(() =>
            {
                var apiCallPath = "/1.2/add_working_hours";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["country_code"] = ExpressionConverter.Convert(countryCode);
                callPayload.Queries["start_date"] = ExpressionConverter.Convert(startDate);
                callPayload.Queries["start_time"] = ExpressionConverter.Convert(startTime);
                callPayload.Queries["increment_time"] = ExpressionConverter.Convert(incrementTime);
                callPayload.Queries["configuration"] = Convert.ToString("Federal holidays");
                if (configuration != null)
                    callPayload.Queries["configuration"] = ExpressionConverter.Convert(configuration);
                callPayload.Queries["weekend"] = Convert.ToString("1000001");
                if (weekend != null)
                    callPayload.Queries["weekend"] = ExpressionConverter.Convert(weekend);
                callPayload.Queries["week_times"] = Convert.ToString("08:00*12:00*14:00*18:00*08:00*12:00*14:00*18:00*08:00*12:00*14:00*18:00*08:00*12:00*14:00*18:00*08:00*12:00*14:00*18:00*08:00*12:00*14:00*18:00*08:00*12:00*14:00*18:00*");
                if (weekTimes != null)
                    callPayload.Queries["week_times"] = ExpressionConverter.Convert(weekTimes);
                if (startTemplate != null)
                    callPayload.Queries["start_template"] = ExpressionConverter.Convert(startTemplate);
                callPayload.Queries["use_custom_configuration"] = Convert.ToString(false);
                if (useCustomConfiguration != null)
                    callPayload.Queries["use_custom_configuration"] = ExpressionConverter.Convert(useCustomConfiguration);
                callPayload.Queries["profile_id"] = Convert.ToString("ut");
                if (profileId != null)
                    callPayload.Queries["profile_id"] = ExpressionConverter.Convert(profileId);
                callPayload.Headers["Accept"] = Convert.ToString("application/json; charset=utf-8");
                return new ApiConnectionAction<AddWorkingHoursResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workingdaysip")]
        [WorkflowExpressionFactory(nameof(__BuildAddPublicHolidays))]
        public IBodyWorkflowAction<AddPublicHolidaysResponse> AddPublicHolidays([WorkflowExpression] Func<countryCodeInput> countryCode, [WorkflowExpression] Func<string> startDate, [WorkflowExpression] Func<string> increment, [WorkflowExpression] Func<bool> includeStart, [WorkflowExpression] Func<string> configuration = null, [WorkflowExpression] Func<string> weekend = null, [WorkflowExpression] Func<string> weekTimes = null, [WorkflowExpression] Func<string> startTemplate = null, [WorkflowExpression] Func<bool> useCustomConfiguration = null, [WorkflowExpression] Func<string> profileId = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workingdaysip")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<AddPublicHolidaysResponse> __BuildAddPublicHolidays(WorkflowExpression<countryCodeInput> countryCode, WorkflowExpression<string> startDate, WorkflowExpression<string> increment, WorkflowExpression<bool> includeStart, WorkflowExpression<string> configuration = null, WorkflowExpression<string> weekend = null, WorkflowExpression<string> weekTimes = null, WorkflowExpression<string> startTemplate = null, WorkflowExpression<bool> useCustomConfiguration = null, WorkflowExpression<string> profileId = null)
        {
            WorkflowExpression.Validate(countryCode, nameof(countryCode), required: true);
            WorkflowExpression.Validate(startDate, nameof(startDate), required: true);
            WorkflowExpression.Validate(increment, nameof(increment), required: true);
            WorkflowExpression.Validate(includeStart, nameof(includeStart), required: true);
            WorkflowExpression.Validate(configuration, nameof(configuration), required: false);
            WorkflowExpression.Validate(weekend, nameof(weekend), required: false);
            WorkflowExpression.Validate(weekTimes, nameof(weekTimes), required: false);
            WorkflowExpression.Validate(startTemplate, nameof(startTemplate), required: false);
            WorkflowExpression.Validate(useCustomConfiguration, nameof(useCustomConfiguration), required: false);
            WorkflowExpression.Validate(profileId, nameof(profileId), required: false);
            return new DeferredBodyAction<AddPublicHolidaysResponse>(() =>
            {
                var apiCallPath = "/1.2/add_public_holidays";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["country_code"] = ExpressionConverter.Convert(countryCode);
                callPayload.Queries["start_date"] = ExpressionConverter.Convert(startDate);
                callPayload.Queries["increment"] = ExpressionConverter.Convert(increment);
                callPayload.Queries["include_start"] = ExpressionConverter.Convert(includeStart);
                callPayload.Queries["configuration"] = Convert.ToString("Federal holidays");
                if (configuration != null)
                    callPayload.Queries["configuration"] = ExpressionConverter.Convert(configuration);
                callPayload.Queries["weekend"] = Convert.ToString("1000001");
                if (weekend != null)
                    callPayload.Queries["weekend"] = ExpressionConverter.Convert(weekend);
                callPayload.Queries["week_times"] = Convert.ToString("08:00*12:00*14:00*18:00*08:00*12:00*14:00*18:00*08:00*12:00*14:00*18:00*08:00*12:00*14:00*18:00*08:00*12:00*14:00*18:00*08:00*12:00*14:00*18:00*08:00*12:00*14:00*18:00*");
                if (weekTimes != null)
                    callPayload.Queries["week_times"] = ExpressionConverter.Convert(weekTimes);
                if (startTemplate != null)
                    callPayload.Queries["start_template"] = ExpressionConverter.Convert(startTemplate);
                callPayload.Queries["use_custom_configuration"] = Convert.ToString(false);
                if (useCustomConfiguration != null)
                    callPayload.Queries["use_custom_configuration"] = ExpressionConverter.Convert(useCustomConfiguration);
                callPayload.Queries["profile_id"] = Convert.ToString("ut");
                if (profileId != null)
                    callPayload.Queries["profile_id"] = ExpressionConverter.Convert(profileId);
                callPayload.Headers["Accept"] = Convert.ToString("application/json; charset=utf-8");
                return new ApiConnectionAction<AddPublicHolidaysResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workingdaysip")]
        [WorkflowExpressionFactory(nameof(__BuildAddWeekendDays))]
        public IBodyWorkflowAction<AddWeekendDaysResponse> AddWeekendDays([WorkflowExpression] Func<countryCodeInput> countryCode, [WorkflowExpression] Func<string> startDate, [WorkflowExpression] Func<string> increment, [WorkflowExpression] Func<bool> includeStart, [WorkflowExpression] Func<string> configuration = null, [WorkflowExpression] Func<string> weekend = null, [WorkflowExpression] Func<string> weekTimes = null, [WorkflowExpression] Func<string> startTemplate = null, [WorkflowExpression] Func<bool> useCustomConfiguration = null, [WorkflowExpression] Func<string> profileId = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workingdaysip")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<AddWeekendDaysResponse> __BuildAddWeekendDays(WorkflowExpression<countryCodeInput> countryCode, WorkflowExpression<string> startDate, WorkflowExpression<string> increment, WorkflowExpression<bool> includeStart, WorkflowExpression<string> configuration = null, WorkflowExpression<string> weekend = null, WorkflowExpression<string> weekTimes = null, WorkflowExpression<string> startTemplate = null, WorkflowExpression<bool> useCustomConfiguration = null, WorkflowExpression<string> profileId = null)
        {
            WorkflowExpression.Validate(countryCode, nameof(countryCode), required: true);
            WorkflowExpression.Validate(startDate, nameof(startDate), required: true);
            WorkflowExpression.Validate(increment, nameof(increment), required: true);
            WorkflowExpression.Validate(includeStart, nameof(includeStart), required: true);
            WorkflowExpression.Validate(configuration, nameof(configuration), required: false);
            WorkflowExpression.Validate(weekend, nameof(weekend), required: false);
            WorkflowExpression.Validate(weekTimes, nameof(weekTimes), required: false);
            WorkflowExpression.Validate(startTemplate, nameof(startTemplate), required: false);
            WorkflowExpression.Validate(useCustomConfiguration, nameof(useCustomConfiguration), required: false);
            WorkflowExpression.Validate(profileId, nameof(profileId), required: false);
            return new DeferredBodyAction<AddWeekendDaysResponse>(() =>
            {
                var apiCallPath = "/1.2/add_weekend_days";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["country_code"] = ExpressionConverter.Convert(countryCode);
                callPayload.Queries["start_date"] = ExpressionConverter.Convert(startDate);
                callPayload.Queries["increment"] = ExpressionConverter.Convert(increment);
                callPayload.Queries["include_start"] = ExpressionConverter.Convert(includeStart);
                callPayload.Queries["configuration"] = Convert.ToString("Federal holidays");
                if (configuration != null)
                    callPayload.Queries["configuration"] = ExpressionConverter.Convert(configuration);
                callPayload.Queries["weekend"] = Convert.ToString("1000001");
                if (weekend != null)
                    callPayload.Queries["weekend"] = ExpressionConverter.Convert(weekend);
                callPayload.Queries["week_times"] = Convert.ToString("08:00*12:00*14:00*18:00*08:00*12:00*14:00*18:00*08:00*12:00*14:00*18:00*08:00*12:00*14:00*18:00*08:00*12:00*14:00*18:00*08:00*12:00*14:00*18:00*08:00*12:00*14:00*18:00*");
                if (weekTimes != null)
                    callPayload.Queries["week_times"] = ExpressionConverter.Convert(weekTimes);
                if (startTemplate != null)
                    callPayload.Queries["start_template"] = ExpressionConverter.Convert(startTemplate);
                callPayload.Queries["use_custom_configuration"] = Convert.ToString(false);
                if (useCustomConfiguration != null)
                    callPayload.Queries["use_custom_configuration"] = ExpressionConverter.Convert(useCustomConfiguration);
                callPayload.Queries["profile_id"] = Convert.ToString("ut");
                if (profileId != null)
                    callPayload.Queries["profile_id"] = ExpressionConverter.Convert(profileId);
                callPayload.Headers["Accept"] = Convert.ToString("application/json; charset=utf-8");
                return new ApiConnectionAction<AddWeekendDaysResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workingdaysip")]
        [WorkflowExpressionFactory(nameof(__BuildAddressToConfiguration))]
        public IBodyWorkflowAction<AddressToConfigurationResponse> AddressToConfiguration([WorkflowExpression] Func<string> address)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workingdaysip")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<AddressToConfigurationResponse> __BuildAddressToConfiguration(WorkflowExpression<string> address)
        {
            WorkflowExpression.Validate(address, nameof(address), required: true);
            return new DeferredBodyAction<AddressToConfigurationResponse>(() =>
            {
                var apiCallPath = "/1.2/address_to_configuration";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["address"] = ExpressionConverter.Convert(address);
                callPayload.Headers["Accept"] = Convert.ToString("application/json; charset=utf-8");
                return new ApiConnectionAction<AddressToConfigurationResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workingdaysip")]
        public IBodyWorkflowAction<QuotaResponse> Quota()
        {
            var apiCallPath = "/1.2/quota";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["Accept"] = Convert.ToString("application/json; charset=utf-8");
            return new ApiConnectionAction<QuotaResponse>(callPayload);
        }
    }

    public class WorkingdaysipTriggers([ConnectionName] string connectionId)
    {
    }

    public class AddWorkingDaysResponse
    {
        [JsonProperty("result")]
        public AddWorkingDaysResponseResultType Result { get; set; }
    }

    public class AddWorkingDaysResponseResultType
    {
        [JsonProperty("end_date")]
        public string EndDate { get; set; }

        [JsonProperty("days")]
        public AddWorkingDaysResponseResultTypeDaysType Days { get; set; }

        [JsonProperty("working_days")]
        public AddWorkingDaysResponseResultTypeWorkingDaysType WorkingDays { get; set; }

        [JsonProperty("weekend_days")]
        public AddWorkingDaysResponseResultTypeWeekendDaysType WeekendDays { get; set; }

        [JsonProperty("public_holidays")]
        public JToken PublicHolidays { get; set; }
    }

    public class AddWorkingDaysResponseResultTypeDaysType
    {
        [JsonProperty("total")]
        public string Total { get; set; }

        [JsonProperty("mondays")]
        public string Mondays { get; set; }

        [JsonProperty("tuesdays")]
        public string Tuesdays { get; set; }

        [JsonProperty("wednesdays")]
        public string Wednesdays { get; set; }

        [JsonProperty("thursdays")]
        public string Thursdays { get; set; }

        [JsonProperty("fridays")]
        public string Fridays { get; set; }

        [JsonProperty("saturdays")]
        public string Saturdays { get; set; }

        [JsonProperty("sundays")]
        public string Sundays { get; set; }

        [JsonProperty("hours")]
        public string Hours { get; set; }
    }

    public class AddWorkingDaysResponseResultTypeWorkingDaysType
    {
        [JsonProperty("total")]
        public string Total { get; set; }

        [JsonProperty("mondays")]
        public string Mondays { get; set; }

        [JsonProperty("tuesdays")]
        public string Tuesdays { get; set; }

        [JsonProperty("wednesdays")]
        public string Wednesdays { get; set; }

        [JsonProperty("thursdays")]
        public string Thursdays { get; set; }

        [JsonProperty("fridays")]
        public string Fridays { get; set; }

        [JsonProperty("saturdays")]
        public string Saturdays { get; set; }

        [JsonProperty("sundays")]
        public string Sundays { get; set; }

        [JsonProperty("work_hours")]
        public string WorkHours { get; set; }

        [JsonProperty("wages")]
        public string Wages { get; set; }
    }

    public class AddWorkingDaysResponseResultTypeWeekendDaysType
    {
        [JsonProperty("total")]
        public string Total { get; set; }

        [JsonProperty("mondays")]
        public string Mondays { get; set; }

        [JsonProperty("tuesdays")]
        public string Tuesdays { get; set; }

        [JsonProperty("wednesdays")]
        public string Wednesdays { get; set; }

        [JsonProperty("thursdays")]
        public string Thursdays { get; set; }

        [JsonProperty("fridays")]
        public string Fridays { get; set; }

        [JsonProperty("saturdays")]
        public string Saturdays { get; set; }

        [JsonProperty("sundays")]
        public string Sundays { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum countryCodeInput
    {
        AR,
        AU,
        AT,
        BE,
        BR,
        BG,
        CA,
        CL,
        CN,
        CO,
        CZ,
        DK,
        DE,
        ES,
        FI,
        FR,
        GR,
        HK,
        HU,
        IN,
        IL,
        IT,
        JP,
        LU,
        MC,
        MX,
        NL,
        NZ,
        NO,
        PE,
        PL,
        PT,
        RO,
        RU,
        SG,
        SK,
        ZA,
        KR,
        CH,
        SE,
        TR,
        US,
        UA,
        GB,
        VE
    }

    public class AnalyzeResponse
    {
        [JsonProperty("result")]
        public AnalyzeResponseResultType Result { get; set; }
    }

    public class AnalyzeResponseResultType
    {
        [JsonProperty("end_date")]
        public string EndDate { get; set; }

        [JsonProperty("days")]
        public AnalyzeResponseResultTypeDaysType Days { get; set; }

        [JsonProperty("working_days")]
        public AnalyzeResponseResultTypeWorkingDaysType WorkingDays { get; set; }

        [JsonProperty("weekend_days")]
        public AnalyzeResponseResultTypeWeekendDaysType WeekendDays { get; set; }

        [JsonProperty("public_holidays")]
        public JToken PublicHolidays { get; set; }
    }

    public class AnalyzeResponseResultTypeDaysType
    {
        [JsonProperty("total")]
        public string Total { get; set; }

        [JsonProperty("mondays")]
        public string Mondays { get; set; }

        [JsonProperty("tuesdays")]
        public string Tuesdays { get; set; }

        [JsonProperty("wednesdays")]
        public string Wednesdays { get; set; }

        [JsonProperty("thursdays")]
        public string Thursdays { get; set; }

        [JsonProperty("fridays")]
        public string Fridays { get; set; }

        [JsonProperty("saturdays")]
        public string Saturdays { get; set; }

        [JsonProperty("sundays")]
        public string Sundays { get; set; }

        [JsonProperty("hours")]
        public string Hours { get; set; }
    }

    public class AnalyzeResponseResultTypeWorkingDaysType
    {
        [JsonProperty("total")]
        public string Total { get; set; }

        [JsonProperty("mondays")]
        public string Mondays { get; set; }

        [JsonProperty("tuesdays")]
        public string Tuesdays { get; set; }

        [JsonProperty("wednesdays")]
        public string Wednesdays { get; set; }

        [JsonProperty("thursdays")]
        public string Thursdays { get; set; }

        [JsonProperty("fridays")]
        public string Fridays { get; set; }

        [JsonProperty("saturdays")]
        public string Saturdays { get; set; }

        [JsonProperty("sundays")]
        public string Sundays { get; set; }

        [JsonProperty("work_hours")]
        public string WorkHours { get; set; }

        [JsonProperty("wages")]
        public string Wages { get; set; }
    }

    public class AnalyzeResponseResultTypeWeekendDaysType
    {
        [JsonProperty("total")]
        public string Total { get; set; }

        [JsonProperty("mondays")]
        public string Mondays { get; set; }

        [JsonProperty("tuesdays")]
        public string Tuesdays { get; set; }

        [JsonProperty("wednesdays")]
        public string Wednesdays { get; set; }

        [JsonProperty("thursdays")]
        public string Thursdays { get; set; }

        [JsonProperty("fridays")]
        public string Fridays { get; set; }

        [JsonProperty("saturdays")]
        public string Saturdays { get; set; }

        [JsonProperty("sundays")]
        public string Sundays { get; set; }
    }

    public class GetInfoDayResponse
    {
        [JsonProperty("result")]
        public GetInfoDayResponseResultType Result { get; set; }
    }

    public class GetInfoDayResponseResultType
    {
        [JsonProperty("working_day")]
        public string WorkingDay { get; set; }

        [JsonProperty("work_hours")]
        public string WorkHours { get; set; }

        [JsonProperty("wages")]
        public string Wages { get; set; }

        [JsonProperty("morning_start")]
        public string MorningStart { get; set; }

        [JsonProperty("morning_end")]
        public string MorningEnd { get; set; }

        [JsonProperty("afternoon_start")]
        public string AfternoonStart { get; set; }

        [JsonProperty("afternoon_end")]
        public string AfternoonEnd { get; set; }

        [JsonProperty("public_holiday")]
        public string PublicHoliday { get; set; }

        [JsonProperty("public_holiday_description")]
        public string PublicHolidayDescription { get; set; }

        [JsonProperty("weekend_day")]
        public string WeekendDay { get; set; }

        [JsonProperty("custom_date")]
        public string CustomDate { get; set; }

        [JsonProperty("custom_date_description")]
        public string CustomDateDescription { get; set; }

        [JsonProperty("custom_date_color")]
        public string CustomDateColor { get; set; }
    }

    public class ListNonWorkingDaysResponse
    {
        [JsonProperty("result")]
        public ListNonWorkingDaysResponseResultType Result { get; set; }
    }

    public class ListNonWorkingDaysResponseResultType
    {
        [JsonProperty("non_working_days")]
        public JToken NonWorkingDays { get; set; }
    }

    public class AddWorkingHoursResponse
    {
        [JsonProperty("result")]
        public AddWorkingHoursResponseResultType Result { get; set; }
    }

    public class AddWorkingHoursResponseResultType
    {
        [JsonProperty("end_date")]
        public string EndDate { get; set; }

        [JsonProperty("end_time")]
        public string EndTime { get; set; }
    }

    public class AddPublicHolidaysResponse
    {
        [JsonProperty("result")]
        public AddPublicHolidaysResponseResultType Result { get; set; }
    }

    public class AddPublicHolidaysResponseResultType
    {
        [JsonProperty("end_date")]
        public string EndDate { get; set; }

        [JsonProperty("days")]
        public AddPublicHolidaysResponseResultTypeDaysType Days { get; set; }

        [JsonProperty("working_days")]
        public AddPublicHolidaysResponseResultTypeWorkingDaysType WorkingDays { get; set; }

        [JsonProperty("weekend_days")]
        public AddPublicHolidaysResponseResultTypeWeekendDaysType WeekendDays { get; set; }

        [JsonProperty("public_holidays")]
        public JToken PublicHolidays { get; set; }
    }

    public class AddPublicHolidaysResponseResultTypeDaysType
    {
        [JsonProperty("total")]
        public string Total { get; set; }

        [JsonProperty("mondays")]
        public string Mondays { get; set; }

        [JsonProperty("tuesdays")]
        public string Tuesdays { get; set; }

        [JsonProperty("wednesdays")]
        public string Wednesdays { get; set; }

        [JsonProperty("thursdays")]
        public string Thursdays { get; set; }

        [JsonProperty("fridays")]
        public string Fridays { get; set; }

        [JsonProperty("saturdays")]
        public string Saturdays { get; set; }

        [JsonProperty("sundays")]
        public string Sundays { get; set; }

        [JsonProperty("hours")]
        public string Hours { get; set; }
    }

    public class AddPublicHolidaysResponseResultTypeWorkingDaysType
    {
        [JsonProperty("total")]
        public string Total { get; set; }

        [JsonProperty("mondays")]
        public string Mondays { get; set; }

        [JsonProperty("tuesdays")]
        public string Tuesdays { get; set; }

        [JsonProperty("wednesdays")]
        public string Wednesdays { get; set; }

        [JsonProperty("thursdays")]
        public string Thursdays { get; set; }

        [JsonProperty("fridays")]
        public string Fridays { get; set; }

        [JsonProperty("saturdays")]
        public string Saturdays { get; set; }

        [JsonProperty("sundays")]
        public string Sundays { get; set; }

        [JsonProperty("work_hours")]
        public string WorkHours { get; set; }

        [JsonProperty("wages")]
        public string Wages { get; set; }
    }

    public class AddPublicHolidaysResponseResultTypeWeekendDaysType
    {
        [JsonProperty("total")]
        public string Total { get; set; }

        [JsonProperty("mondays")]
        public string Mondays { get; set; }

        [JsonProperty("tuesdays")]
        public string Tuesdays { get; set; }

        [JsonProperty("wednesdays")]
        public string Wednesdays { get; set; }

        [JsonProperty("thursdays")]
        public string Thursdays { get; set; }

        [JsonProperty("fridays")]
        public string Fridays { get; set; }

        [JsonProperty("saturdays")]
        public string Saturdays { get; set; }

        [JsonProperty("sundays")]
        public string Sundays { get; set; }
    }

    public class AddWeekendDaysResponse
    {
        [JsonProperty("result")]
        public AddWeekendDaysResponseResultType Result { get; set; }
    }

    public class AddWeekendDaysResponseResultType
    {
        [JsonProperty("end_date")]
        public string EndDate { get; set; }

        [JsonProperty("days")]
        public AddWeekendDaysResponseResultTypeDaysType Days { get; set; }

        [JsonProperty("working_days")]
        public AddWeekendDaysResponseResultTypeWorkingDaysType WorkingDays { get; set; }

        [JsonProperty("weekend_days")]
        public AddWeekendDaysResponseResultTypeWeekendDaysType WeekendDays { get; set; }

        [JsonProperty("public_holidays")]
        public JToken PublicHolidays { get; set; }
    }

    public class AddWeekendDaysResponseResultTypeDaysType
    {
        [JsonProperty("total")]
        public string Total { get; set; }

        [JsonProperty("mondays")]
        public string Mondays { get; set; }

        [JsonProperty("tuesdays")]
        public string Tuesdays { get; set; }

        [JsonProperty("wednesdays")]
        public string Wednesdays { get; set; }

        [JsonProperty("thursdays")]
        public string Thursdays { get; set; }

        [JsonProperty("fridays")]
        public string Fridays { get; set; }

        [JsonProperty("saturdays")]
        public string Saturdays { get; set; }

        [JsonProperty("sundays")]
        public string Sundays { get; set; }

        [JsonProperty("hours")]
        public string Hours { get; set; }
    }

    public class AddWeekendDaysResponseResultTypeWorkingDaysType
    {
        [JsonProperty("total")]
        public string Total { get; set; }

        [JsonProperty("mondays")]
        public string Mondays { get; set; }

        [JsonProperty("tuesdays")]
        public string Tuesdays { get; set; }

        [JsonProperty("wednesdays")]
        public string Wednesdays { get; set; }

        [JsonProperty("thursdays")]
        public string Thursdays { get; set; }

        [JsonProperty("fridays")]
        public string Fridays { get; set; }

        [JsonProperty("saturdays")]
        public string Saturdays { get; set; }

        [JsonProperty("sundays")]
        public string Sundays { get; set; }

        [JsonProperty("work_hours")]
        public string WorkHours { get; set; }

        [JsonProperty("wages")]
        public string Wages { get; set; }
    }

    public class AddWeekendDaysResponseResultTypeWeekendDaysType
    {
        [JsonProperty("total")]
        public string Total { get; set; }

        [JsonProperty("mondays")]
        public string Mondays { get; set; }

        [JsonProperty("tuesdays")]
        public string Tuesdays { get; set; }

        [JsonProperty("wednesdays")]
        public string Wednesdays { get; set; }

        [JsonProperty("thursdays")]
        public string Thursdays { get; set; }

        [JsonProperty("fridays")]
        public string Fridays { get; set; }

        [JsonProperty("saturdays")]
        public string Saturdays { get; set; }

        [JsonProperty("sundays")]
        public string Sundays { get; set; }
    }

    public class AddressToConfigurationResponse
    {
        [JsonProperty("result")]
        public AddressToConfigurationResponseResultType Result { get; set; }
    }

    public class AddressToConfigurationResponseResultType
    {
        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("country_code")]
        public string CountryCode { get; set; }

        [JsonProperty("configuration")]
        public string Configuration { get; set; }

        [JsonProperty("formatted_address")]
        public string FormattedAddress { get; set; }
    }

    public class QuotaResponse
    {
        [JsonProperty("result")]
        public QuotaResponseResultType Result { get; set; }
    }

    public class QuotaResponseResultType
    {
        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("current")]
        public string Current { get; set; }

        [JsonProperty("next")]
        public string Next { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Workingdaysip;

    public partial class WorkflowManagedActions
    {
        public WorkingdaysipActions Workingdaysip(string connectionId) => new WorkingdaysipActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public WorkingdaysipTriggers Workingdaysip(string connectionId) => new WorkingdaysipTriggers(connectionId);
    }
}