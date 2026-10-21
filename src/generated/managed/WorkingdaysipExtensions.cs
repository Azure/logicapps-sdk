//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------
namespace Microsoft.Azure.Workflows.Sdk.Connectors.Workingdaysip
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class WorkingdaysipActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workingdaysip")]
        public IBodyWorkflowAction<AddWorkingDaysResponse> AddWorkingDays(Expression<Func<countryCodeInput>> countryCode, Expression<Func<string>> startDate, Expression<Func<string>> increment, Expression<Func<bool>> includeStart, Expression<Func<string>> configuration = null, Expression<Func<string>> weekend = null, Expression<Func<string>> weekTimes = null, Expression<Func<string>> startTemplate = null, Expression<Func<bool>> useCustomConfiguration = null, Expression<Func<string>> profileId = null)
        {
            var __workflow_countryCode = WorkflowExpression.Compile(countryCode, nameof(countryCode), required: true);
            var __workflow_startDate = WorkflowExpression.Compile(startDate, nameof(startDate), required: true);
            var __workflow_increment = WorkflowExpression.Compile(increment, nameof(increment), required: true);
            var __workflow_includeStart = WorkflowExpression.Compile(includeStart, nameof(includeStart), required: true);
            var __workflow_configuration = WorkflowExpression.Compile(configuration, nameof(configuration), required: false);
            var __workflow_weekend = WorkflowExpression.Compile(weekend, nameof(weekend), required: false);
            var __workflow_weekTimes = WorkflowExpression.Compile(weekTimes, nameof(weekTimes), required: false);
            var __workflow_startTemplate = WorkflowExpression.Compile(startTemplate, nameof(startTemplate), required: false);
            var __workflow_useCustomConfiguration = WorkflowExpression.Compile(useCustomConfiguration, nameof(useCustomConfiguration), required: false);
            var __workflow_profileId = WorkflowExpression.Compile(profileId, nameof(profileId), required: false);
            return new DeferredBodyAction<AddWorkingDaysResponse>(() =>
            {
                var apiCallPath = "/1.2/add_working_days";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["country_code"] = ExpressionConverter.Convert(__workflow_countryCode);
                callPayload.Queries["start_date"] = ExpressionConverter.Convert(__workflow_startDate);
                callPayload.Queries["increment"] = ExpressionConverter.Convert(__workflow_increment);
                callPayload.Queries["include_start"] = ExpressionConverter.Convert(__workflow_includeStart);
                callPayload.Queries["configuration"] = Convert.ToString("Federal holidays");
                if (__workflow_configuration != null)
                    callPayload.Queries["configuration"] = ExpressionConverter.Convert(__workflow_configuration);
                callPayload.Queries["weekend"] = Convert.ToString("1000001");
                if (__workflow_weekend != null)
                    callPayload.Queries["weekend"] = ExpressionConverter.Convert(__workflow_weekend);
                callPayload.Queries["week_times"] = Convert.ToString("08:00*12:00*14:00*18:00*08:00*12:00*14:00*18:00*08:00*12:00*14:00*18:00*08:00*12:00*14:00*18:00*08:00*12:00*14:00*18:00*08:00*12:00*14:00*18:00*08:00*12:00*14:00*18:00*");
                if (__workflow_weekTimes != null)
                    callPayload.Queries["week_times"] = ExpressionConverter.Convert(__workflow_weekTimes);
                if (__workflow_startTemplate != null)
                    callPayload.Queries["start_template"] = ExpressionConverter.Convert(__workflow_startTemplate);
                callPayload.Queries["use_custom_configuration"] = Convert.ToString(false);
                if (__workflow_useCustomConfiguration != null)
                    callPayload.Queries["use_custom_configuration"] = ExpressionConverter.Convert(__workflow_useCustomConfiguration);
                callPayload.Queries["profile_id"] = Convert.ToString("ut");
                if (__workflow_profileId != null)
                    callPayload.Queries["profile_id"] = ExpressionConverter.Convert(__workflow_profileId);
                callPayload.Headers["Accept"] = Convert.ToString("application/json; charset=utf-8");
                return new ApiConnectionAction<AddWorkingDaysResponse>(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workingdaysip")]
        public IBodyWorkflowAction<AnalyzeResponse> Analyze(Expression<Func<countryCodeInput>> countryCode, Expression<Func<string>> startDate, Expression<Func<string>> endDate, Expression<Func<string>> startTime = null, Expression<Func<string>> endTime = null, Expression<Func<string>> configuration = null, Expression<Func<string>> weekend = null, Expression<Func<string>> weekTimes = null, Expression<Func<string>> startTemplate = null, Expression<Func<bool>> useCustomConfiguration = null, Expression<Func<string>> profileId = null)
        {
            var __workflow_countryCode = WorkflowExpression.Compile(countryCode, nameof(countryCode), required: true);
            var __workflow_startDate = WorkflowExpression.Compile(startDate, nameof(startDate), required: true);
            var __workflow_endDate = WorkflowExpression.Compile(endDate, nameof(endDate), required: true);
            var __workflow_startTime = WorkflowExpression.Compile(startTime, nameof(startTime), required: false);
            var __workflow_endTime = WorkflowExpression.Compile(endTime, nameof(endTime), required: false);
            var __workflow_configuration = WorkflowExpression.Compile(configuration, nameof(configuration), required: false);
            var __workflow_weekend = WorkflowExpression.Compile(weekend, nameof(weekend), required: false);
            var __workflow_weekTimes = WorkflowExpression.Compile(weekTimes, nameof(weekTimes), required: false);
            var __workflow_startTemplate = WorkflowExpression.Compile(startTemplate, nameof(startTemplate), required: false);
            var __workflow_useCustomConfiguration = WorkflowExpression.Compile(useCustomConfiguration, nameof(useCustomConfiguration), required: false);
            var __workflow_profileId = WorkflowExpression.Compile(profileId, nameof(profileId), required: false);
            return new DeferredBodyAction<AnalyzeResponse>(() =>
            {
                var apiCallPath = "/1.2/analyse";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["country_code"] = ExpressionConverter.Convert(__workflow_countryCode);
                callPayload.Queries["start_date"] = ExpressionConverter.Convert(__workflow_startDate);
                callPayload.Queries["end_date"] = ExpressionConverter.Convert(__workflow_endDate);
                if (__workflow_startTime != null)
                    callPayload.Queries["start_time"] = ExpressionConverter.Convert(__workflow_startTime);
                if (__workflow_endTime != null)
                    callPayload.Queries["end_time"] = ExpressionConverter.Convert(__workflow_endTime);
                callPayload.Queries["configuration"] = Convert.ToString("Federal holidays");
                if (__workflow_configuration != null)
                    callPayload.Queries["configuration"] = ExpressionConverter.Convert(__workflow_configuration);
                callPayload.Queries["weekend"] = Convert.ToString("1000001");
                if (__workflow_weekend != null)
                    callPayload.Queries["weekend"] = ExpressionConverter.Convert(__workflow_weekend);
                callPayload.Queries["week_times"] = Convert.ToString("08:00*12:00*14:00*18:00*08:00*12:00*14:00*18:00*08:00*12:00*14:00*18:00*08:00*12:00*14:00*18:00*08:00*12:00*14:00*18:00*08:00*12:00*14:00*18:00*08:00*12:00*14:00*18:00*");
                if (__workflow_weekTimes != null)
                    callPayload.Queries["week_times"] = ExpressionConverter.Convert(__workflow_weekTimes);
                if (__workflow_startTemplate != null)
                    callPayload.Queries["start_template"] = ExpressionConverter.Convert(__workflow_startTemplate);
                callPayload.Queries["use_custom_configuration"] = Convert.ToString(false);
                if (__workflow_useCustomConfiguration != null)
                    callPayload.Queries["use_custom_configuration"] = ExpressionConverter.Convert(__workflow_useCustomConfiguration);
                callPayload.Queries["profile_id"] = Convert.ToString("ut");
                if (__workflow_profileId != null)
                    callPayload.Queries["profile_id"] = ExpressionConverter.Convert(__workflow_profileId);
                callPayload.Headers["Accept"] = Convert.ToString("application/json; charset=utf-8");
                return new ApiConnectionAction<AnalyzeResponse>(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workingdaysip")]
        public IBodyWorkflowAction<GetInfoDayResponse> GetInfoDay(Expression<Func<countryCodeInput>> countryCode, Expression<Func<string>> date, Expression<Func<string>> configuration = null, Expression<Func<string>> weekend = null, Expression<Func<bool>> useCustomConfiguration = null, Expression<Func<string>> profileId = null)
        {
            var __workflow_countryCode = WorkflowExpression.Compile(countryCode, nameof(countryCode), required: true);
            var __workflow_date = WorkflowExpression.Compile(date, nameof(date), required: true);
            var __workflow_configuration = WorkflowExpression.Compile(configuration, nameof(configuration), required: false);
            var __workflow_weekend = WorkflowExpression.Compile(weekend, nameof(weekend), required: false);
            var __workflow_useCustomConfiguration = WorkflowExpression.Compile(useCustomConfiguration, nameof(useCustomConfiguration), required: false);
            var __workflow_profileId = WorkflowExpression.Compile(profileId, nameof(profileId), required: false);
            return new DeferredBodyAction<GetInfoDayResponse>(() =>
            {
                var apiCallPath = "/1.2/get_info_day";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["country_code"] = ExpressionConverter.Convert(__workflow_countryCode);
                callPayload.Queries["date"] = ExpressionConverter.Convert(__workflow_date);
                callPayload.Queries["configuration"] = Convert.ToString("Federal holidays");
                if (__workflow_configuration != null)
                    callPayload.Queries["configuration"] = ExpressionConverter.Convert(__workflow_configuration);
                callPayload.Queries["weekend"] = Convert.ToString("1000001");
                if (__workflow_weekend != null)
                    callPayload.Queries["weekend"] = ExpressionConverter.Convert(__workflow_weekend);
                callPayload.Queries["use_custom_configuration"] = Convert.ToString(false);
                if (__workflow_useCustomConfiguration != null)
                    callPayload.Queries["use_custom_configuration"] = ExpressionConverter.Convert(__workflow_useCustomConfiguration);
                callPayload.Queries["profile_id"] = Convert.ToString("ut");
                if (__workflow_profileId != null)
                    callPayload.Queries["profile_id"] = ExpressionConverter.Convert(__workflow_profileId);
                callPayload.Headers["Accept"] = Convert.ToString("application/json; charset=utf-8");
                return new ApiConnectionAction<GetInfoDayResponse>(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workingdaysip")]
        public IBodyWorkflowAction<ListNonWorkingDaysResponse> ListNonWorkingDays(Expression<Func<countryCodeInput>> countryCode, Expression<Func<string>> startDate, Expression<Func<string>> endDate, Expression<Func<string>> configuration = null, Expression<Func<string>> weekend = null, Expression<Func<bool>> useCustomConfiguration = null, Expression<Func<string>> profileId = null)
        {
            var __workflow_countryCode = WorkflowExpression.Compile(countryCode, nameof(countryCode), required: true);
            var __workflow_startDate = WorkflowExpression.Compile(startDate, nameof(startDate), required: true);
            var __workflow_endDate = WorkflowExpression.Compile(endDate, nameof(endDate), required: true);
            var __workflow_configuration = WorkflowExpression.Compile(configuration, nameof(configuration), required: false);
            var __workflow_weekend = WorkflowExpression.Compile(weekend, nameof(weekend), required: false);
            var __workflow_useCustomConfiguration = WorkflowExpression.Compile(useCustomConfiguration, nameof(useCustomConfiguration), required: false);
            var __workflow_profileId = WorkflowExpression.Compile(profileId, nameof(profileId), required: false);
            return new DeferredBodyAction<ListNonWorkingDaysResponse>(() =>
            {
                var apiCallPath = "/1.2/list_non_working_days";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["country_code"] = ExpressionConverter.Convert(__workflow_countryCode);
                callPayload.Queries["start_date"] = ExpressionConverter.Convert(__workflow_startDate);
                callPayload.Queries["end_date"] = ExpressionConverter.Convert(__workflow_endDate);
                callPayload.Queries["configuration"] = Convert.ToString("Federal holidays");
                if (__workflow_configuration != null)
                    callPayload.Queries["configuration"] = ExpressionConverter.Convert(__workflow_configuration);
                callPayload.Queries["weekend"] = Convert.ToString("1000001");
                if (__workflow_weekend != null)
                    callPayload.Queries["weekend"] = ExpressionConverter.Convert(__workflow_weekend);
                callPayload.Queries["use_custom_configuration"] = Convert.ToString(false);
                if (__workflow_useCustomConfiguration != null)
                    callPayload.Queries["use_custom_configuration"] = ExpressionConverter.Convert(__workflow_useCustomConfiguration);
                callPayload.Queries["profile_id"] = Convert.ToString("ut");
                if (__workflow_profileId != null)
                    callPayload.Queries["profile_id"] = ExpressionConverter.Convert(__workflow_profileId);
                callPayload.Headers["Accept"] = Convert.ToString("application/json; charset=utf-8");
                return new ApiConnectionAction<ListNonWorkingDaysResponse>(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workingdaysip")]
        public IBodyWorkflowAction<AddWorkingHoursResponse> AddWorkingHours(Expression<Func<countryCodeInput>> countryCode, Expression<Func<string>> startDate, Expression<Func<string>> startTime, Expression<Func<string>> incrementTime, Expression<Func<string>> configuration = null, Expression<Func<string>> weekend = null, Expression<Func<string>> weekTimes = null, Expression<Func<string>> startTemplate = null, Expression<Func<bool>> useCustomConfiguration = null, Expression<Func<string>> profileId = null)
        {
            var __workflow_countryCode = WorkflowExpression.Compile(countryCode, nameof(countryCode), required: true);
            var __workflow_startDate = WorkflowExpression.Compile(startDate, nameof(startDate), required: true);
            var __workflow_startTime = WorkflowExpression.Compile(startTime, nameof(startTime), required: true);
            var __workflow_incrementTime = WorkflowExpression.Compile(incrementTime, nameof(incrementTime), required: true);
            var __workflow_configuration = WorkflowExpression.Compile(configuration, nameof(configuration), required: false);
            var __workflow_weekend = WorkflowExpression.Compile(weekend, nameof(weekend), required: false);
            var __workflow_weekTimes = WorkflowExpression.Compile(weekTimes, nameof(weekTimes), required: false);
            var __workflow_startTemplate = WorkflowExpression.Compile(startTemplate, nameof(startTemplate), required: false);
            var __workflow_useCustomConfiguration = WorkflowExpression.Compile(useCustomConfiguration, nameof(useCustomConfiguration), required: false);
            var __workflow_profileId = WorkflowExpression.Compile(profileId, nameof(profileId), required: false);
            return new DeferredBodyAction<AddWorkingHoursResponse>(() =>
            {
                var apiCallPath = "/1.2/add_working_hours";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["country_code"] = ExpressionConverter.Convert(__workflow_countryCode);
                callPayload.Queries["start_date"] = ExpressionConverter.Convert(__workflow_startDate);
                callPayload.Queries["start_time"] = ExpressionConverter.Convert(__workflow_startTime);
                callPayload.Queries["increment_time"] = ExpressionConverter.Convert(__workflow_incrementTime);
                callPayload.Queries["configuration"] = Convert.ToString("Federal holidays");
                if (__workflow_configuration != null)
                    callPayload.Queries["configuration"] = ExpressionConverter.Convert(__workflow_configuration);
                callPayload.Queries["weekend"] = Convert.ToString("1000001");
                if (__workflow_weekend != null)
                    callPayload.Queries["weekend"] = ExpressionConverter.Convert(__workflow_weekend);
                callPayload.Queries["week_times"] = Convert.ToString("08:00*12:00*14:00*18:00*08:00*12:00*14:00*18:00*08:00*12:00*14:00*18:00*08:00*12:00*14:00*18:00*08:00*12:00*14:00*18:00*08:00*12:00*14:00*18:00*08:00*12:00*14:00*18:00*");
                if (__workflow_weekTimes != null)
                    callPayload.Queries["week_times"] = ExpressionConverter.Convert(__workflow_weekTimes);
                if (__workflow_startTemplate != null)
                    callPayload.Queries["start_template"] = ExpressionConverter.Convert(__workflow_startTemplate);
                callPayload.Queries["use_custom_configuration"] = Convert.ToString(false);
                if (__workflow_useCustomConfiguration != null)
                    callPayload.Queries["use_custom_configuration"] = ExpressionConverter.Convert(__workflow_useCustomConfiguration);
                callPayload.Queries["profile_id"] = Convert.ToString("ut");
                if (__workflow_profileId != null)
                    callPayload.Queries["profile_id"] = ExpressionConverter.Convert(__workflow_profileId);
                callPayload.Headers["Accept"] = Convert.ToString("application/json; charset=utf-8");
                return new ApiConnectionAction<AddWorkingHoursResponse>(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workingdaysip")]
        public IBodyWorkflowAction<AddPublicHolidaysResponse> AddPublicHolidays(Expression<Func<countryCodeInput>> countryCode, Expression<Func<string>> startDate, Expression<Func<string>> increment, Expression<Func<bool>> includeStart, Expression<Func<string>> configuration = null, Expression<Func<string>> weekend = null, Expression<Func<string>> weekTimes = null, Expression<Func<string>> startTemplate = null, Expression<Func<bool>> useCustomConfiguration = null, Expression<Func<string>> profileId = null)
        {
            var __workflow_countryCode = WorkflowExpression.Compile(countryCode, nameof(countryCode), required: true);
            var __workflow_startDate = WorkflowExpression.Compile(startDate, nameof(startDate), required: true);
            var __workflow_increment = WorkflowExpression.Compile(increment, nameof(increment), required: true);
            var __workflow_includeStart = WorkflowExpression.Compile(includeStart, nameof(includeStart), required: true);
            var __workflow_configuration = WorkflowExpression.Compile(configuration, nameof(configuration), required: false);
            var __workflow_weekend = WorkflowExpression.Compile(weekend, nameof(weekend), required: false);
            var __workflow_weekTimes = WorkflowExpression.Compile(weekTimes, nameof(weekTimes), required: false);
            var __workflow_startTemplate = WorkflowExpression.Compile(startTemplate, nameof(startTemplate), required: false);
            var __workflow_useCustomConfiguration = WorkflowExpression.Compile(useCustomConfiguration, nameof(useCustomConfiguration), required: false);
            var __workflow_profileId = WorkflowExpression.Compile(profileId, nameof(profileId), required: false);
            return new DeferredBodyAction<AddPublicHolidaysResponse>(() =>
            {
                var apiCallPath = "/1.2/add_public_holidays";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["country_code"] = ExpressionConverter.Convert(__workflow_countryCode);
                callPayload.Queries["start_date"] = ExpressionConverter.Convert(__workflow_startDate);
                callPayload.Queries["increment"] = ExpressionConverter.Convert(__workflow_increment);
                callPayload.Queries["include_start"] = ExpressionConverter.Convert(__workflow_includeStart);
                callPayload.Queries["configuration"] = Convert.ToString("Federal holidays");
                if (__workflow_configuration != null)
                    callPayload.Queries["configuration"] = ExpressionConverter.Convert(__workflow_configuration);
                callPayload.Queries["weekend"] = Convert.ToString("1000001");
                if (__workflow_weekend != null)
                    callPayload.Queries["weekend"] = ExpressionConverter.Convert(__workflow_weekend);
                callPayload.Queries["week_times"] = Convert.ToString("08:00*12:00*14:00*18:00*08:00*12:00*14:00*18:00*08:00*12:00*14:00*18:00*08:00*12:00*14:00*18:00*08:00*12:00*14:00*18:00*08:00*12:00*14:00*18:00*08:00*12:00*14:00*18:00*");
                if (__workflow_weekTimes != null)
                    callPayload.Queries["week_times"] = ExpressionConverter.Convert(__workflow_weekTimes);
                if (__workflow_startTemplate != null)
                    callPayload.Queries["start_template"] = ExpressionConverter.Convert(__workflow_startTemplate);
                callPayload.Queries["use_custom_configuration"] = Convert.ToString(false);
                if (__workflow_useCustomConfiguration != null)
                    callPayload.Queries["use_custom_configuration"] = ExpressionConverter.Convert(__workflow_useCustomConfiguration);
                callPayload.Queries["profile_id"] = Convert.ToString("ut");
                if (__workflow_profileId != null)
                    callPayload.Queries["profile_id"] = ExpressionConverter.Convert(__workflow_profileId);
                callPayload.Headers["Accept"] = Convert.ToString("application/json; charset=utf-8");
                return new ApiConnectionAction<AddPublicHolidaysResponse>(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workingdaysip")]
        public IBodyWorkflowAction<AddWeekendDaysResponse> AddWeekendDays(Expression<Func<countryCodeInput>> countryCode, Expression<Func<string>> startDate, Expression<Func<string>> increment, Expression<Func<bool>> includeStart, Expression<Func<string>> configuration = null, Expression<Func<string>> weekend = null, Expression<Func<string>> weekTimes = null, Expression<Func<string>> startTemplate = null, Expression<Func<bool>> useCustomConfiguration = null, Expression<Func<string>> profileId = null)
        {
            var __workflow_countryCode = WorkflowExpression.Compile(countryCode, nameof(countryCode), required: true);
            var __workflow_startDate = WorkflowExpression.Compile(startDate, nameof(startDate), required: true);
            var __workflow_increment = WorkflowExpression.Compile(increment, nameof(increment), required: true);
            var __workflow_includeStart = WorkflowExpression.Compile(includeStart, nameof(includeStart), required: true);
            var __workflow_configuration = WorkflowExpression.Compile(configuration, nameof(configuration), required: false);
            var __workflow_weekend = WorkflowExpression.Compile(weekend, nameof(weekend), required: false);
            var __workflow_weekTimes = WorkflowExpression.Compile(weekTimes, nameof(weekTimes), required: false);
            var __workflow_startTemplate = WorkflowExpression.Compile(startTemplate, nameof(startTemplate), required: false);
            var __workflow_useCustomConfiguration = WorkflowExpression.Compile(useCustomConfiguration, nameof(useCustomConfiguration), required: false);
            var __workflow_profileId = WorkflowExpression.Compile(profileId, nameof(profileId), required: false);
            return new DeferredBodyAction<AddWeekendDaysResponse>(() =>
            {
                var apiCallPath = "/1.2/add_weekend_days";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["country_code"] = ExpressionConverter.Convert(__workflow_countryCode);
                callPayload.Queries["start_date"] = ExpressionConverter.Convert(__workflow_startDate);
                callPayload.Queries["increment"] = ExpressionConverter.Convert(__workflow_increment);
                callPayload.Queries["include_start"] = ExpressionConverter.Convert(__workflow_includeStart);
                callPayload.Queries["configuration"] = Convert.ToString("Federal holidays");
                if (__workflow_configuration != null)
                    callPayload.Queries["configuration"] = ExpressionConverter.Convert(__workflow_configuration);
                callPayload.Queries["weekend"] = Convert.ToString("1000001");
                if (__workflow_weekend != null)
                    callPayload.Queries["weekend"] = ExpressionConverter.Convert(__workflow_weekend);
                callPayload.Queries["week_times"] = Convert.ToString("08:00*12:00*14:00*18:00*08:00*12:00*14:00*18:00*08:00*12:00*14:00*18:00*08:00*12:00*14:00*18:00*08:00*12:00*14:00*18:00*08:00*12:00*14:00*18:00*08:00*12:00*14:00*18:00*");
                if (__workflow_weekTimes != null)
                    callPayload.Queries["week_times"] = ExpressionConverter.Convert(__workflow_weekTimes);
                if (__workflow_startTemplate != null)
                    callPayload.Queries["start_template"] = ExpressionConverter.Convert(__workflow_startTemplate);
                callPayload.Queries["use_custom_configuration"] = Convert.ToString(false);
                if (__workflow_useCustomConfiguration != null)
                    callPayload.Queries["use_custom_configuration"] = ExpressionConverter.Convert(__workflow_useCustomConfiguration);
                callPayload.Queries["profile_id"] = Convert.ToString("ut");
                if (__workflow_profileId != null)
                    callPayload.Queries["profile_id"] = ExpressionConverter.Convert(__workflow_profileId);
                callPayload.Headers["Accept"] = Convert.ToString("application/json; charset=utf-8");
                return new ApiConnectionAction<AddWeekendDaysResponse>(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workingdaysip")]
        public IBodyWorkflowAction<AddressToConfigurationResponse> AddressToConfiguration(Expression<Func<string>> address)
        {
            var __workflow_address = WorkflowExpression.Compile(address, nameof(address), required: true);
            return new DeferredBodyAction<AddressToConfigurationResponse>(() =>
            {
                var apiCallPath = "/1.2/address_to_configuration";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["address"] = ExpressionConverter.Convert(__workflow_address);
                callPayload.Headers["Accept"] = Convert.ToString("application/json; charset=utf-8");
                return new ApiConnectionAction<AddressToConfigurationResponse>(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
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
