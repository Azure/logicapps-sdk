//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Calculateworkingday
{
        using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class CalculateworkingdayActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "calculateworkingday")]
        [WorkflowExpressionFactory(nameof(__BuildCombined))]
        public IBodyWorkflowAction<CombinedResponse> Combined([WorkflowExpression] Func<string> date, [WorkflowExpression] Func<string> workingDays, [WorkflowExpression] Func<int> xWorkingDays, [WorkflowExpression] Func<string> nonWorkingDays = null, [WorkflowExpression] Func<string> country = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<CombinedResponse> __BuildCombined(WorkflowValue<string> date, WorkflowValue<string> workingDays, WorkflowValue<int> xWorkingDays, WorkflowValue<string> nonWorkingDays = null, WorkflowValue<string> country = null)
        {
            WorkflowValue.Validate(date, nameof(date), required: true);
            WorkflowValue.Validate(workingDays, nameof(workingDays), required: true);
            WorkflowValue.Validate(xWorkingDays, nameof(xWorkingDays), required: true);
            WorkflowValue.Validate(nonWorkingDays, nameof(nonWorkingDays), required: false);
            WorkflowValue.Validate(country, nameof(country), required: false);
            return new DeferredBodyAction<CombinedResponse>(() =>
            {
                var apiCallPath = "/combined/";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["date"] = ExpressionConverter.Convert(date);
                callPayload.Queries["working_days"] = ExpressionConverter.Convert(workingDays);
                if (nonWorkingDays != null)
                    callPayload.Queries["non_working_days"] = ExpressionConverter.Convert(nonWorkingDays);
                callPayload.Queries["x_working_days"] = ExpressionConverter.Convert(xWorkingDays);
                callPayload.Queries["country"] = Convert.ToString("scotland");
                if (country != null)
                    callPayload.Queries["country"] = ExpressionConverter.Convert(country);
                callPayload.Headers["cf"] = Convert.ToString("sk");
                return new ApiConnectionAction<CombinedResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "calculateworkingday")]
        [WorkflowExpressionFactory(nameof(__BuildBasicNextWorkingDay))]
        public IBodyWorkflowAction<BasicNextWorkingDayResponse> BasicNextWorkingDay([WorkflowExpression] Func<string> date)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<BasicNextWorkingDayResponse> __BuildBasicNextWorkingDay(WorkflowValue<string> date)
        {
            WorkflowValue.Validate(date, nameof(date), required: true);
            return new DeferredBodyAction<BasicNextWorkingDayResponse>(() =>
            {
                var apiCallPath = "/basicNextWorkingDay/";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["date"] = ExpressionConverter.Convert(date);
                callPayload.Headers["cf"] = Convert.ToString("sk");
                return new ApiConnectionAction<BasicNextWorkingDayResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "calculateworkingday")]
        [WorkflowExpressionFactory(nameof(__BuildNextWorkingDay))]
        public IBodyWorkflowAction<NextWorkingDayResponse> NextWorkingDay([WorkflowExpression] Func<string> date, [WorkflowExpression] Func<string> workingDays, [WorkflowExpression] Func<int> xWorkingDays, [WorkflowExpression] Func<string> nonWorkingDays = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<NextWorkingDayResponse> __BuildNextWorkingDay(WorkflowValue<string> date, WorkflowValue<string> workingDays, WorkflowValue<int> xWorkingDays, WorkflowValue<string> nonWorkingDays = null)
        {
            WorkflowValue.Validate(date, nameof(date), required: true);
            WorkflowValue.Validate(workingDays, nameof(workingDays), required: true);
            WorkflowValue.Validate(xWorkingDays, nameof(xWorkingDays), required: true);
            WorkflowValue.Validate(nonWorkingDays, nameof(nonWorkingDays), required: false);
            return new DeferredBodyAction<NextWorkingDayResponse>(() =>
            {
                var apiCallPath = "/nextWorkingDay/";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["date"] = ExpressionConverter.Convert(date);
                callPayload.Queries["working_days"] = ExpressionConverter.Convert(workingDays);
                if (nonWorkingDays != null)
                    callPayload.Queries["non_working_days"] = ExpressionConverter.Convert(nonWorkingDays);
                callPayload.Queries["x_working_days"] = ExpressionConverter.Convert(xWorkingDays);
                callPayload.Headers["cf"] = Convert.ToString("sk");
                return new ApiConnectionAction<NextWorkingDayResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "calculateworkingday")]
        [WorkflowExpressionFactory(nameof(__BuildDateDifferenceCalculator))]
        public IBodyWorkflowAction<DateDifferenceCalculatorResponse> DateDifferenceCalculator([WorkflowExpression] Func<string> workingDays, [WorkflowExpression] Func<string> startDate, [WorkflowExpression] Func<string> endDate, [WorkflowExpression] Func<string> nonWorkingDays = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<DateDifferenceCalculatorResponse> __BuildDateDifferenceCalculator(WorkflowValue<string> workingDays, WorkflowValue<string> startDate, WorkflowValue<string> endDate, WorkflowValue<string> nonWorkingDays = null)
        {
            WorkflowValue.Validate(workingDays, nameof(workingDays), required: true);
            WorkflowValue.Validate(startDate, nameof(startDate), required: true);
            WorkflowValue.Validate(endDate, nameof(endDate), required: true);
            WorkflowValue.Validate(nonWorkingDays, nameof(nonWorkingDays), required: false);
            return new DeferredBodyAction<DateDifferenceCalculatorResponse>(() =>
            {
                var apiCallPath = "/dateDifferenceCalculator/";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (nonWorkingDays != null)
                    callPayload.Queries["non_working_days"] = ExpressionConverter.Convert(nonWorkingDays);
                callPayload.Queries["working_days"] = ExpressionConverter.Convert(workingDays);
                callPayload.Queries["start_date"] = ExpressionConverter.Convert(startDate);
                callPayload.Queries["end_date"] = ExpressionConverter.Convert(endDate);
                callPayload.Headers["cf"] = Convert.ToString("sk");
                return new ApiConnectionAction<DateDifferenceCalculatorResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "calculateworkingday")]
        [WorkflowExpressionFactory(nameof(__BuildFirstAndLastWorkingDayOfMonth))]
        public IBodyWorkflowAction<FirstAndLastWorkingDayOfMonthResponse> FirstAndLastWorkingDayOfMonth([WorkflowExpression] Func<string> date, [WorkflowExpression] Func<string> workingDays)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<FirstAndLastWorkingDayOfMonthResponse> __BuildFirstAndLastWorkingDayOfMonth(WorkflowValue<string> date, WorkflowValue<string> workingDays)
        {
            WorkflowValue.Validate(date, nameof(date), required: true);
            WorkflowValue.Validate(workingDays, nameof(workingDays), required: true);
            return new DeferredBodyAction<FirstAndLastWorkingDayOfMonthResponse>(() =>
            {
                var apiCallPath = "/firstAndLastWorkingDayOfMonth/";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["date"] = ExpressionConverter.Convert(date);
                callPayload.Queries["working_days"] = ExpressionConverter.Convert(workingDays);
                callPayload.Headers["cf"] = Convert.ToString("sk");
                return new ApiConnectionAction<FirstAndLastWorkingDayOfMonthResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "calculateworkingday")]
        [WorkflowExpressionFactory(nameof(__BuildIsTodayAWorkingDay))]
        public IBodyWorkflowAction<IsTodayAWorkingDayResponse> IsTodayAWorkingDay([WorkflowExpression] Func<string> date, [WorkflowExpression] Func<string> workingDays)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<IsTodayAWorkingDayResponse> __BuildIsTodayAWorkingDay(WorkflowValue<string> date, WorkflowValue<string> workingDays)
        {
            WorkflowValue.Validate(date, nameof(date), required: true);
            WorkflowValue.Validate(workingDays, nameof(workingDays), required: true);
            return new DeferredBodyAction<IsTodayAWorkingDayResponse>(() =>
            {
                var apiCallPath = "/isTodayAWorkingDay/";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["date"] = ExpressionConverter.Convert(date);
                callPayload.Queries["working_days"] = ExpressionConverter.Convert(workingDays);
                callPayload.Headers["cf"] = Convert.ToString("sk");
                return new ApiConnectionAction<IsTodayAWorkingDayResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "calculateworkingday")]
        [WorkflowExpressionFactory(nameof(__BuildDateInXWorkingDays))]
        public IBodyWorkflowAction<DateInXWorkingDaysResponse> DateInXWorkingDays([WorkflowExpression] Func<string> date, [WorkflowExpression] Func<string> workingDays, [WorkflowExpression] Func<int> xWorkingDays)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<DateInXWorkingDaysResponse> __BuildDateInXWorkingDays(WorkflowValue<string> date, WorkflowValue<string> workingDays, WorkflowValue<int> xWorkingDays)
        {
            WorkflowValue.Validate(date, nameof(date), required: true);
            WorkflowValue.Validate(workingDays, nameof(workingDays), required: true);
            WorkflowValue.Validate(xWorkingDays, nameof(xWorkingDays), required: true);
            return new DeferredBodyAction<DateInXWorkingDaysResponse>(() =>
            {
                var apiCallPath = "/dateInXWorkingDays/";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["date"] = ExpressionConverter.Convert(date);
                callPayload.Queries["working_days"] = ExpressionConverter.Convert(workingDays);
                callPayload.Queries["x_working_days"] = ExpressionConverter.Convert(xWorkingDays);
                callPayload.Headers["cf"] = Convert.ToString("sk");
                return new ApiConnectionAction<DateInXWorkingDaysResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "calculateworkingday")]
        public IBodyWorkflowAction<CountryResponse> Country()
        {
            var apiCallPath = "/bank-holidays.json";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<CountryResponse>(callPayload);
        }
    }

    public class CalculateworkingdayTriggers([ConnectionName] string connectionId)
    {
    }

    public class CombinedResponse
    {
        [JsonProperty("input_date")]
        public string InputDate { get; set; }

        [JsonProperty("is_input_date_a_working_day")]
        public bool IsInputDateAWorkingDay { get; set; }

        [JsonProperty("working_days")]
        public string[] WorkingDays { get; set; }

        [JsonProperty("non_working_days")]
        public string[] WorkingDaysInWords { get; set; }

        [JsonProperty("x_days")]
        public int NextWorkingDay { get; set; }

        [JsonProperty("working_day_in_x_days")]
        public string WorkingDayInXDays { get; set; }

        [JsonProperty("first_working_day_of_month")]
        public string FirstWorkingDayOfMonth { get; set; }

        [JsonProperty("last_working_day_of_month")]
        public string LastWorkingDayOfMonth { get; set; }

        [JsonProperty("more_info")]
        public string MoreInfo { get; set; }

        [JsonProperty("message_from_developer")]
        public string MessageFromDeveloper { get; set; }
    }

    public class BasicNextWorkingDayResponse
    {
        [JsonProperty("input_date")]
        public string InputDate { get; set; }

        [JsonProperty("next_working_day")]
        public string NextWorkingDay { get; set; }

        [JsonProperty("more_info")]
        public string MoreInfo { get; set; }

        [JsonProperty("message_from_developer")]
        public string MessageFromDeveloper { get; set; }
    }

    public class NextWorkingDayResponse
    {
        [JsonProperty("input_date")]
        public string InputDate { get; set; }

        [JsonProperty("working_days")]
        public string[] WorkingDays { get; set; }

        [JsonProperty("non_working_days")]
        public string[] WorkingDaysInWords { get; set; }

        [JsonProperty("next_working_day")]
        public string NextWorkingDay { get; set; }

        [JsonProperty("more_info")]
        public string MoreInfo { get; set; }

        [JsonProperty("message_from_developer")]
        public string MessageFromDeveloper { get; set; }
    }

    public class DateDifferenceCalculatorResponse
    {
        [JsonProperty("start_date")]
        public string StartDate { get; set; }

        [JsonProperty("end_date")]
        public string EndDate { get; set; }

        [JsonProperty("total_days")]
        public int TotalDays { get; set; }

        [JsonProperty("working_days_count")]
        public int WorkingDaysCount { get; set; }

        [JsonProperty("working_days")]
        public string[] WorkingDays { get; set; }

        [JsonProperty("non_working_days")]
        public string[] WorkingDaysInWords { get; set; }

        [JsonProperty("more_info")]
        public string MoreInfo { get; set; }

        [JsonProperty("message_from_developer")]
        public string MessageFromDeveloper { get; set; }
    }

    public class FirstAndLastWorkingDayOfMonthResponse
    {
        [JsonProperty("input_date")]
        public string InputDate { get; set; }

        [JsonProperty("working_days")]
        public string[] WorkingDays { get; set; }

        [JsonProperty("non_working_days")]
        public string[] WorkingDaysInWords { get; set; }

        [JsonProperty("first_working_day_of_month")]
        public string FirstWorkingDayOfMonth { get; set; }

        [JsonProperty("last_working_day_of_month")]
        public string LastWorkingDayOfMonth { get; set; }

        [JsonProperty("more_info")]
        public string MoreInfo { get; set; }

        [JsonProperty("message_from_developer")]
        public string MessageFromDeveloper { get; set; }
    }

    public class IsTodayAWorkingDayResponse
    {
        [JsonProperty("input_date")]
        public string InputDate { get; set; }

        [JsonProperty("is_input_date_a_working_day")]
        public bool IsInputDateAWorkingDay { get; set; }

        [JsonProperty("working_days")]
        public string[] WorkingDays { get; set; }

        [JsonProperty("non_working_days")]
        public string[] WorkingDaysInWords { get; set; }

        [JsonProperty("more_info")]
        public string MoreInfo { get; set; }

        [JsonProperty("message_from_developer")]
        public string MessageFromDeveloper { get; set; }
    }

    public class DateInXWorkingDaysResponse
    {
        [JsonProperty("input_date")]
        public string InputDate { get; set; }

        [JsonProperty("working_days")]
        public string[] WorkingDays { get; set; }

        [JsonProperty("non_working_days")]
        public string[] WorkingDaysInWords { get; set; }

        [JsonProperty("x_days")]
        public int NextWorkingDay { get; set; }

        [JsonProperty("working_day_in_x_days")]
        public string WorkingDayInXDays { get; set; }

        [JsonProperty("more_info")]
        public string MoreInfo { get; set; }

        [JsonProperty("message_from_developer")]
        public string MessageFromDeveloper { get; set; }
    }

    public class CountryResponse
    {
        [JsonProperty("countrys")]
        public CountryResponseCountrysTypeItem[] Countrys { get; set; }
    }

    public class CountryResponseCountrysTypeItem
    {
        [JsonProperty("country")]
        public string Country { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Calculateworkingday;

    public partial class WorkflowManagedActions
    {
        public CalculateworkingdayActions Calculateworkingday(string connectionId) => new CalculateworkingdayActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public CalculateworkingdayTriggers Calculateworkingday(string connectionId) => new CalculateworkingdayTriggers(connectionId);
    }
}
