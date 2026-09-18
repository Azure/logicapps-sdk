//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Workingdaysip
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class WorkingdaysipActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workingdaysip")]
        public IBodyWorkflowAction<AddWorkingDaysResponse> AddWorkingDays([WorkflowExpression] Func<countryCodeInput> countryCode, [WorkflowExpression] Func<string> startDate, [WorkflowExpression] Func<string> increment, [WorkflowExpression] Func<bool> includeStart, [WorkflowExpression] Func<string> configuration = null, [WorkflowExpression] Func<string> weekend = null, [WorkflowExpression] Func<string> weekTimes = null, [WorkflowExpression] Func<string> startTemplate = null, [WorkflowExpression] Func<bool> useCustomConfiguration = null, [WorkflowExpression] Func<string> profileId = null)
        {
            SourceExpression.Validate(countryCode, nameof(countryCode), required: true);
            SourceExpression.Validate(startDate, nameof(startDate), required: true);
            SourceExpression.Validate(increment, nameof(increment), required: true);
            SourceExpression.Validate(includeStart, nameof(includeStart), required: true);
            SourceExpression.Validate(configuration, nameof(configuration), required: false);
            SourceExpression.Validate(weekend, nameof(weekend), required: false);
            SourceExpression.Validate(weekTimes, nameof(weekTimes), required: false);
            SourceExpression.Validate(startTemplate, nameof(startTemplate), required: false);
            SourceExpression.Validate(useCustomConfiguration, nameof(useCustomConfiguration), required: false);
            SourceExpression.Validate(profileId, nameof(profileId), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/1.2/add_working_days";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["country_code"] = SourceExpressionConverter.Convert(countryCode);
                callPayload.Queries["start_date"] = SourceExpressionConverter.ConvertO(startDate);
                callPayload.Queries["increment"] = SourceExpressionConverter.ConvertO(increment);
                callPayload.Queries["include_start"] = SourceExpressionConverter.ConvertO(includeStart);
                callPayload.Queries["configuration"] = Convert.ToString("Federal holidays");
                if (configuration != null)
                    callPayload.Queries["configuration"] = SourceExpressionConverter.ConvertO(configuration);
                callPayload.Queries["weekend"] = Convert.ToString("1000001");
                if (weekend != null)
                    callPayload.Queries["weekend"] = SourceExpressionConverter.ConvertO(weekend);
                callPayload.Queries["week_times"] = Convert.ToString("08:00*12:00*14:00*18:00*08:00*12:00*14:00*18:00*08:00*12:00*14:00*18:00*08:00*12:00*14:00*18:00*08:00*12:00*14:00*18:00*08:00*12:00*14:00*18:00*08:00*12:00*14:00*18:00*");
                if (weekTimes != null)
                    callPayload.Queries["week_times"] = SourceExpressionConverter.ConvertO(weekTimes);
                if (startTemplate != null)
                    callPayload.Queries["start_template"] = SourceExpressionConverter.ConvertO(startTemplate);
                callPayload.Queries["use_custom_configuration"] = Convert.ToString(false);
                if (useCustomConfiguration != null)
                    callPayload.Queries["use_custom_configuration"] = SourceExpressionConverter.ConvertO(useCustomConfiguration);
                callPayload.Queries["profile_id"] = Convert.ToString("ut");
                if (profileId != null)
                    callPayload.Queries["profile_id"] = SourceExpressionConverter.ConvertO(profileId);
                callPayload.Headers["Accept"] = Convert.ToString("application/json; charset=utf-8");
                return callPayload;
            }

            return new ApiConnectionAction<AddWorkingDaysResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workingdaysip")]
        public IBodyWorkflowAction<AnalyzeResponse> Analyze([WorkflowExpression] Func<countryCodeInput> countryCode, [WorkflowExpression] Func<string> startDate, [WorkflowExpression] Func<string> endDate, [WorkflowExpression] Func<string> startTime = null, [WorkflowExpression] Func<string> endTime = null, [WorkflowExpression] Func<string> configuration = null, [WorkflowExpression] Func<string> weekend = null, [WorkflowExpression] Func<string> weekTimes = null, [WorkflowExpression] Func<string> startTemplate = null, [WorkflowExpression] Func<bool> useCustomConfiguration = null, [WorkflowExpression] Func<string> profileId = null)
        {
            SourceExpression.Validate(countryCode, nameof(countryCode), required: true);
            SourceExpression.Validate(startDate, nameof(startDate), required: true);
            SourceExpression.Validate(endDate, nameof(endDate), required: true);
            SourceExpression.Validate(startTime, nameof(startTime), required: false);
            SourceExpression.Validate(endTime, nameof(endTime), required: false);
            SourceExpression.Validate(configuration, nameof(configuration), required: false);
            SourceExpression.Validate(weekend, nameof(weekend), required: false);
            SourceExpression.Validate(weekTimes, nameof(weekTimes), required: false);
            SourceExpression.Validate(startTemplate, nameof(startTemplate), required: false);
            SourceExpression.Validate(useCustomConfiguration, nameof(useCustomConfiguration), required: false);
            SourceExpression.Validate(profileId, nameof(profileId), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/1.2/analyse";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["country_code"] = SourceExpressionConverter.Convert(countryCode);
                callPayload.Queries["start_date"] = SourceExpressionConverter.ConvertO(startDate);
                callPayload.Queries["end_date"] = SourceExpressionConverter.ConvertO(endDate);
                if (startTime != null)
                    callPayload.Queries["start_time"] = SourceExpressionConverter.ConvertO(startTime);
                if (endTime != null)
                    callPayload.Queries["end_time"] = SourceExpressionConverter.ConvertO(endTime);
                callPayload.Queries["configuration"] = Convert.ToString("Federal holidays");
                if (configuration != null)
                    callPayload.Queries["configuration"] = SourceExpressionConverter.ConvertO(configuration);
                callPayload.Queries["weekend"] = Convert.ToString("1000001");
                if (weekend != null)
                    callPayload.Queries["weekend"] = SourceExpressionConverter.ConvertO(weekend);
                callPayload.Queries["week_times"] = Convert.ToString("08:00*12:00*14:00*18:00*08:00*12:00*14:00*18:00*08:00*12:00*14:00*18:00*08:00*12:00*14:00*18:00*08:00*12:00*14:00*18:00*08:00*12:00*14:00*18:00*08:00*12:00*14:00*18:00*");
                if (weekTimes != null)
                    callPayload.Queries["week_times"] = SourceExpressionConverter.ConvertO(weekTimes);
                if (startTemplate != null)
                    callPayload.Queries["start_template"] = SourceExpressionConverter.ConvertO(startTemplate);
                callPayload.Queries["use_custom_configuration"] = Convert.ToString(false);
                if (useCustomConfiguration != null)
                    callPayload.Queries["use_custom_configuration"] = SourceExpressionConverter.ConvertO(useCustomConfiguration);
                callPayload.Queries["profile_id"] = Convert.ToString("ut");
                if (profileId != null)
                    callPayload.Queries["profile_id"] = SourceExpressionConverter.ConvertO(profileId);
                callPayload.Headers["Accept"] = Convert.ToString("application/json; charset=utf-8");
                return callPayload;
            }

            return new ApiConnectionAction<AnalyzeResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workingdaysip")]
        public IBodyWorkflowAction<GetInfoDayResponse> GetInfoDay([WorkflowExpression] Func<countryCodeInput> countryCode, [WorkflowExpression] Func<string> date, [WorkflowExpression] Func<string> configuration = null, [WorkflowExpression] Func<string> weekend = null, [WorkflowExpression] Func<bool> useCustomConfiguration = null, [WorkflowExpression] Func<string> profileId = null)
        {
            SourceExpression.Validate(countryCode, nameof(countryCode), required: true);
            SourceExpression.Validate(date, nameof(date), required: true);
            SourceExpression.Validate(configuration, nameof(configuration), required: false);
            SourceExpression.Validate(weekend, nameof(weekend), required: false);
            SourceExpression.Validate(useCustomConfiguration, nameof(useCustomConfiguration), required: false);
            SourceExpression.Validate(profileId, nameof(profileId), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/1.2/get_info_day";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["country_code"] = SourceExpressionConverter.Convert(countryCode);
                callPayload.Queries["date"] = SourceExpressionConverter.ConvertO(date);
                callPayload.Queries["configuration"] = Convert.ToString("Federal holidays");
                if (configuration != null)
                    callPayload.Queries["configuration"] = SourceExpressionConverter.ConvertO(configuration);
                callPayload.Queries["weekend"] = Convert.ToString("1000001");
                if (weekend != null)
                    callPayload.Queries["weekend"] = SourceExpressionConverter.ConvertO(weekend);
                callPayload.Queries["use_custom_configuration"] = Convert.ToString(false);
                if (useCustomConfiguration != null)
                    callPayload.Queries["use_custom_configuration"] = SourceExpressionConverter.ConvertO(useCustomConfiguration);
                callPayload.Queries["profile_id"] = Convert.ToString("ut");
                if (profileId != null)
                    callPayload.Queries["profile_id"] = SourceExpressionConverter.ConvertO(profileId);
                callPayload.Headers["Accept"] = Convert.ToString("application/json; charset=utf-8");
                return callPayload;
            }

            return new ApiConnectionAction<GetInfoDayResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workingdaysip")]
        public IBodyWorkflowAction<ListNonWorkingDaysResponse> ListNonWorkingDays([WorkflowExpression] Func<countryCodeInput> countryCode, [WorkflowExpression] Func<string> startDate, [WorkflowExpression] Func<string> endDate, [WorkflowExpression] Func<string> configuration = null, [WorkflowExpression] Func<string> weekend = null, [WorkflowExpression] Func<bool> useCustomConfiguration = null, [WorkflowExpression] Func<string> profileId = null)
        {
            SourceExpression.Validate(countryCode, nameof(countryCode), required: true);
            SourceExpression.Validate(startDate, nameof(startDate), required: true);
            SourceExpression.Validate(endDate, nameof(endDate), required: true);
            SourceExpression.Validate(configuration, nameof(configuration), required: false);
            SourceExpression.Validate(weekend, nameof(weekend), required: false);
            SourceExpression.Validate(useCustomConfiguration, nameof(useCustomConfiguration), required: false);
            SourceExpression.Validate(profileId, nameof(profileId), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/1.2/list_non_working_days";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["country_code"] = SourceExpressionConverter.Convert(countryCode);
                callPayload.Queries["start_date"] = SourceExpressionConverter.ConvertO(startDate);
                callPayload.Queries["end_date"] = SourceExpressionConverter.ConvertO(endDate);
                callPayload.Queries["configuration"] = Convert.ToString("Federal holidays");
                if (configuration != null)
                    callPayload.Queries["configuration"] = SourceExpressionConverter.ConvertO(configuration);
                callPayload.Queries["weekend"] = Convert.ToString("1000001");
                if (weekend != null)
                    callPayload.Queries["weekend"] = SourceExpressionConverter.ConvertO(weekend);
                callPayload.Queries["use_custom_configuration"] = Convert.ToString(false);
                if (useCustomConfiguration != null)
                    callPayload.Queries["use_custom_configuration"] = SourceExpressionConverter.ConvertO(useCustomConfiguration);
                callPayload.Queries["profile_id"] = Convert.ToString("ut");
                if (profileId != null)
                    callPayload.Queries["profile_id"] = SourceExpressionConverter.ConvertO(profileId);
                callPayload.Headers["Accept"] = Convert.ToString("application/json; charset=utf-8");
                return callPayload;
            }

            return new ApiConnectionAction<ListNonWorkingDaysResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workingdaysip")]
        public IBodyWorkflowAction<AddWorkingHoursResponse> AddWorkingHours([WorkflowExpression] Func<countryCodeInput> countryCode, [WorkflowExpression] Func<string> startDate, [WorkflowExpression] Func<string> startTime, [WorkflowExpression] Func<string> incrementTime, [WorkflowExpression] Func<string> configuration = null, [WorkflowExpression] Func<string> weekend = null, [WorkflowExpression] Func<string> weekTimes = null, [WorkflowExpression] Func<string> startTemplate = null, [WorkflowExpression] Func<bool> useCustomConfiguration = null, [WorkflowExpression] Func<string> profileId = null)
        {
            SourceExpression.Validate(countryCode, nameof(countryCode), required: true);
            SourceExpression.Validate(startDate, nameof(startDate), required: true);
            SourceExpression.Validate(startTime, nameof(startTime), required: true);
            SourceExpression.Validate(incrementTime, nameof(incrementTime), required: true);
            SourceExpression.Validate(configuration, nameof(configuration), required: false);
            SourceExpression.Validate(weekend, nameof(weekend), required: false);
            SourceExpression.Validate(weekTimes, nameof(weekTimes), required: false);
            SourceExpression.Validate(startTemplate, nameof(startTemplate), required: false);
            SourceExpression.Validate(useCustomConfiguration, nameof(useCustomConfiguration), required: false);
            SourceExpression.Validate(profileId, nameof(profileId), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/1.2/add_working_hours";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["country_code"] = SourceExpressionConverter.Convert(countryCode);
                callPayload.Queries["start_date"] = SourceExpressionConverter.ConvertO(startDate);
                callPayload.Queries["start_time"] = SourceExpressionConverter.ConvertO(startTime);
                callPayload.Queries["increment_time"] = SourceExpressionConverter.ConvertO(incrementTime);
                callPayload.Queries["configuration"] = Convert.ToString("Federal holidays");
                if (configuration != null)
                    callPayload.Queries["configuration"] = SourceExpressionConverter.ConvertO(configuration);
                callPayload.Queries["weekend"] = Convert.ToString("1000001");
                if (weekend != null)
                    callPayload.Queries["weekend"] = SourceExpressionConverter.ConvertO(weekend);
                callPayload.Queries["week_times"] = Convert.ToString("08:00*12:00*14:00*18:00*08:00*12:00*14:00*18:00*08:00*12:00*14:00*18:00*08:00*12:00*14:00*18:00*08:00*12:00*14:00*18:00*08:00*12:00*14:00*18:00*08:00*12:00*14:00*18:00*");
                if (weekTimes != null)
                    callPayload.Queries["week_times"] = SourceExpressionConverter.ConvertO(weekTimes);
                if (startTemplate != null)
                    callPayload.Queries["start_template"] = SourceExpressionConverter.ConvertO(startTemplate);
                callPayload.Queries["use_custom_configuration"] = Convert.ToString(false);
                if (useCustomConfiguration != null)
                    callPayload.Queries["use_custom_configuration"] = SourceExpressionConverter.ConvertO(useCustomConfiguration);
                callPayload.Queries["profile_id"] = Convert.ToString("ut");
                if (profileId != null)
                    callPayload.Queries["profile_id"] = SourceExpressionConverter.ConvertO(profileId);
                callPayload.Headers["Accept"] = Convert.ToString("application/json; charset=utf-8");
                return callPayload;
            }

            return new ApiConnectionAction<AddWorkingHoursResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workingdaysip")]
        public IBodyWorkflowAction<AddPublicHolidaysResponse> AddPublicHolidays([WorkflowExpression] Func<countryCodeInput> countryCode, [WorkflowExpression] Func<string> startDate, [WorkflowExpression] Func<string> increment, [WorkflowExpression] Func<bool> includeStart, [WorkflowExpression] Func<string> configuration = null, [WorkflowExpression] Func<string> weekend = null, [WorkflowExpression] Func<string> weekTimes = null, [WorkflowExpression] Func<string> startTemplate = null, [WorkflowExpression] Func<bool> useCustomConfiguration = null, [WorkflowExpression] Func<string> profileId = null)
        {
            SourceExpression.Validate(countryCode, nameof(countryCode), required: true);
            SourceExpression.Validate(startDate, nameof(startDate), required: true);
            SourceExpression.Validate(increment, nameof(increment), required: true);
            SourceExpression.Validate(includeStart, nameof(includeStart), required: true);
            SourceExpression.Validate(configuration, nameof(configuration), required: false);
            SourceExpression.Validate(weekend, nameof(weekend), required: false);
            SourceExpression.Validate(weekTimes, nameof(weekTimes), required: false);
            SourceExpression.Validate(startTemplate, nameof(startTemplate), required: false);
            SourceExpression.Validate(useCustomConfiguration, nameof(useCustomConfiguration), required: false);
            SourceExpression.Validate(profileId, nameof(profileId), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/1.2/add_public_holidays";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["country_code"] = SourceExpressionConverter.Convert(countryCode);
                callPayload.Queries["start_date"] = SourceExpressionConverter.ConvertO(startDate);
                callPayload.Queries["increment"] = SourceExpressionConverter.ConvertO(increment);
                callPayload.Queries["include_start"] = SourceExpressionConverter.ConvertO(includeStart);
                callPayload.Queries["configuration"] = Convert.ToString("Federal holidays");
                if (configuration != null)
                    callPayload.Queries["configuration"] = SourceExpressionConverter.ConvertO(configuration);
                callPayload.Queries["weekend"] = Convert.ToString("1000001");
                if (weekend != null)
                    callPayload.Queries["weekend"] = SourceExpressionConverter.ConvertO(weekend);
                callPayload.Queries["week_times"] = Convert.ToString("08:00*12:00*14:00*18:00*08:00*12:00*14:00*18:00*08:00*12:00*14:00*18:00*08:00*12:00*14:00*18:00*08:00*12:00*14:00*18:00*08:00*12:00*14:00*18:00*08:00*12:00*14:00*18:00*");
                if (weekTimes != null)
                    callPayload.Queries["week_times"] = SourceExpressionConverter.ConvertO(weekTimes);
                if (startTemplate != null)
                    callPayload.Queries["start_template"] = SourceExpressionConverter.ConvertO(startTemplate);
                callPayload.Queries["use_custom_configuration"] = Convert.ToString(false);
                if (useCustomConfiguration != null)
                    callPayload.Queries["use_custom_configuration"] = SourceExpressionConverter.ConvertO(useCustomConfiguration);
                callPayload.Queries["profile_id"] = Convert.ToString("ut");
                if (profileId != null)
                    callPayload.Queries["profile_id"] = SourceExpressionConverter.ConvertO(profileId);
                callPayload.Headers["Accept"] = Convert.ToString("application/json; charset=utf-8");
                return callPayload;
            }

            return new ApiConnectionAction<AddPublicHolidaysResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workingdaysip")]
        public IBodyWorkflowAction<AddWeekendDaysResponse> AddWeekendDays([WorkflowExpression] Func<countryCodeInput> countryCode, [WorkflowExpression] Func<string> startDate, [WorkflowExpression] Func<string> increment, [WorkflowExpression] Func<bool> includeStart, [WorkflowExpression] Func<string> configuration = null, [WorkflowExpression] Func<string> weekend = null, [WorkflowExpression] Func<string> weekTimes = null, [WorkflowExpression] Func<string> startTemplate = null, [WorkflowExpression] Func<bool> useCustomConfiguration = null, [WorkflowExpression] Func<string> profileId = null)
        {
            SourceExpression.Validate(countryCode, nameof(countryCode), required: true);
            SourceExpression.Validate(startDate, nameof(startDate), required: true);
            SourceExpression.Validate(increment, nameof(increment), required: true);
            SourceExpression.Validate(includeStart, nameof(includeStart), required: true);
            SourceExpression.Validate(configuration, nameof(configuration), required: false);
            SourceExpression.Validate(weekend, nameof(weekend), required: false);
            SourceExpression.Validate(weekTimes, nameof(weekTimes), required: false);
            SourceExpression.Validate(startTemplate, nameof(startTemplate), required: false);
            SourceExpression.Validate(useCustomConfiguration, nameof(useCustomConfiguration), required: false);
            SourceExpression.Validate(profileId, nameof(profileId), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/1.2/add_weekend_days";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["country_code"] = SourceExpressionConverter.Convert(countryCode);
                callPayload.Queries["start_date"] = SourceExpressionConverter.ConvertO(startDate);
                callPayload.Queries["increment"] = SourceExpressionConverter.ConvertO(increment);
                callPayload.Queries["include_start"] = SourceExpressionConverter.ConvertO(includeStart);
                callPayload.Queries["configuration"] = Convert.ToString("Federal holidays");
                if (configuration != null)
                    callPayload.Queries["configuration"] = SourceExpressionConverter.ConvertO(configuration);
                callPayload.Queries["weekend"] = Convert.ToString("1000001");
                if (weekend != null)
                    callPayload.Queries["weekend"] = SourceExpressionConverter.ConvertO(weekend);
                callPayload.Queries["week_times"] = Convert.ToString("08:00*12:00*14:00*18:00*08:00*12:00*14:00*18:00*08:00*12:00*14:00*18:00*08:00*12:00*14:00*18:00*08:00*12:00*14:00*18:00*08:00*12:00*14:00*18:00*08:00*12:00*14:00*18:00*");
                if (weekTimes != null)
                    callPayload.Queries["week_times"] = SourceExpressionConverter.ConvertO(weekTimes);
                if (startTemplate != null)
                    callPayload.Queries["start_template"] = SourceExpressionConverter.ConvertO(startTemplate);
                callPayload.Queries["use_custom_configuration"] = Convert.ToString(false);
                if (useCustomConfiguration != null)
                    callPayload.Queries["use_custom_configuration"] = SourceExpressionConverter.ConvertO(useCustomConfiguration);
                callPayload.Queries["profile_id"] = Convert.ToString("ut");
                if (profileId != null)
                    callPayload.Queries["profile_id"] = SourceExpressionConverter.ConvertO(profileId);
                callPayload.Headers["Accept"] = Convert.ToString("application/json; charset=utf-8");
                return callPayload;
            }

            return new ApiConnectionAction<AddWeekendDaysResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workingdaysip")]
        public IBodyWorkflowAction<AddressToConfigurationResponse> AddressToConfiguration([WorkflowExpression] Func<string> address)
        {
            SourceExpression.Validate(address, nameof(address), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/1.2/address_to_configuration";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["address"] = SourceExpressionConverter.ConvertO(address);
                callPayload.Headers["Accept"] = Convert.ToString("application/json; charset=utf-8");
                return callPayload;
            }

            return new ApiConnectionAction<AddressToConfigurationResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workingdaysip")]
        public IBodyWorkflowAction<QuotaResponse> Quota()
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/1.2/quota";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Accept"] = Convert.ToString("application/json; charset=utf-8");
                return callPayload;
            }

            return new ApiConnectionAction<QuotaResponse>(BuildSourceInput);
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