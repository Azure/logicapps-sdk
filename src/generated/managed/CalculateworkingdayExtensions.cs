//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------
namespace Microsoft.Azure.Workflows.Sdk.Connectors.Calculateworkingday
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;
    using System.Linq.Expressions;

    public class CalculateworkingdayActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "calculateworkingday")]
        public IBodyWorkflowAction<CombinedResponse> Combined(Expression<Func<string>> date, Expression<Func<string>> workingDays, Expression<Func<int>> xWorkingDays, Expression<Func<string>> nonWorkingDays = null, Expression<Func<string>> country = null)
        {
            var __workflow_date = date == null ? null : WorkflowExpression.Compile(date);
            WorkflowExpression.Validate(__workflow_date, nameof(date), required: true);
            var __workflow_workingDays = workingDays == null ? null : WorkflowExpression.Compile(workingDays);
            WorkflowExpression.Validate(__workflow_workingDays, nameof(workingDays), required: true);
            var __workflow_xWorkingDays = xWorkingDays == null ? null : WorkflowExpression.Compile(xWorkingDays);
            WorkflowExpression.Validate(__workflow_xWorkingDays, nameof(xWorkingDays), required: true);
            var __workflow_nonWorkingDays = nonWorkingDays == null ? null : WorkflowExpression.Compile(nonWorkingDays);
            WorkflowExpression.Validate(__workflow_nonWorkingDays, nameof(nonWorkingDays), required: false);
            var __workflow_country = country == null ? null : WorkflowExpression.Compile(country);
            WorkflowExpression.Validate(__workflow_country, nameof(country), required: false);
            return new DeferredBodyAction<CombinedResponse>(() =>
            {
                var apiCallPath = "/combined/";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["date"] = ExpressionConverter.Convert(__workflow_date);
                callPayload.Queries["working_days"] = ExpressionConverter.Convert(__workflow_workingDays);
                if (__workflow_nonWorkingDays != null)
                    callPayload.Queries["non_working_days"] = ExpressionConverter.Convert(__workflow_nonWorkingDays);
                callPayload.Queries["x_working_days"] = ExpressionConverter.Convert(__workflow_xWorkingDays);
                callPayload.Queries["country"] = Convert.ToString("scotland");
                if (__workflow_country != null)
                    callPayload.Queries["country"] = ExpressionConverter.Convert(__workflow_country);
                callPayload.Headers["cf"] = Convert.ToString("sk");
                return new ApiConnectionAction<CombinedResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "calculateworkingday")]
        public IBodyWorkflowAction<BasicNextWorkingDayResponse> BasicNextWorkingDay(Expression<Func<string>> date)
        {
            var __workflow_date = date == null ? null : WorkflowExpression.Compile(date);
            WorkflowExpression.Validate(__workflow_date, nameof(date), required: true);
            return new DeferredBodyAction<BasicNextWorkingDayResponse>(() =>
            {
                var apiCallPath = "/basicNextWorkingDay/";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["date"] = ExpressionConverter.Convert(__workflow_date);
                callPayload.Headers["cf"] = Convert.ToString("sk");
                return new ApiConnectionAction<BasicNextWorkingDayResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "calculateworkingday")]
        public IBodyWorkflowAction<NextWorkingDayResponse> NextWorkingDay(Expression<Func<string>> date, Expression<Func<string>> workingDays, Expression<Func<int>> xWorkingDays, Expression<Func<string>> nonWorkingDays = null)
        {
            var __workflow_date = date == null ? null : WorkflowExpression.Compile(date);
            WorkflowExpression.Validate(__workflow_date, nameof(date), required: true);
            var __workflow_workingDays = workingDays == null ? null : WorkflowExpression.Compile(workingDays);
            WorkflowExpression.Validate(__workflow_workingDays, nameof(workingDays), required: true);
            var __workflow_xWorkingDays = xWorkingDays == null ? null : WorkflowExpression.Compile(xWorkingDays);
            WorkflowExpression.Validate(__workflow_xWorkingDays, nameof(xWorkingDays), required: true);
            var __workflow_nonWorkingDays = nonWorkingDays == null ? null : WorkflowExpression.Compile(nonWorkingDays);
            WorkflowExpression.Validate(__workflow_nonWorkingDays, nameof(nonWorkingDays), required: false);
            return new DeferredBodyAction<NextWorkingDayResponse>(() =>
            {
                var apiCallPath = "/nextWorkingDay/";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["date"] = ExpressionConverter.Convert(__workflow_date);
                callPayload.Queries["working_days"] = ExpressionConverter.Convert(__workflow_workingDays);
                if (__workflow_nonWorkingDays != null)
                    callPayload.Queries["non_working_days"] = ExpressionConverter.Convert(__workflow_nonWorkingDays);
                callPayload.Queries["x_working_days"] = ExpressionConverter.Convert(__workflow_xWorkingDays);
                callPayload.Headers["cf"] = Convert.ToString("sk");
                return new ApiConnectionAction<NextWorkingDayResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "calculateworkingday")]
        public IBodyWorkflowAction<DateDifferenceCalculatorResponse> DateDifferenceCalculator(Expression<Func<string>> workingDays, Expression<Func<string>> startDate, Expression<Func<string>> endDate, Expression<Func<string>> nonWorkingDays = null)
        {
            var __workflow_workingDays = workingDays == null ? null : WorkflowExpression.Compile(workingDays);
            WorkflowExpression.Validate(__workflow_workingDays, nameof(workingDays), required: true);
            var __workflow_startDate = startDate == null ? null : WorkflowExpression.Compile(startDate);
            WorkflowExpression.Validate(__workflow_startDate, nameof(startDate), required: true);
            var __workflow_endDate = endDate == null ? null : WorkflowExpression.Compile(endDate);
            WorkflowExpression.Validate(__workflow_endDate, nameof(endDate), required: true);
            var __workflow_nonWorkingDays = nonWorkingDays == null ? null : WorkflowExpression.Compile(nonWorkingDays);
            WorkflowExpression.Validate(__workflow_nonWorkingDays, nameof(nonWorkingDays), required: false);
            return new DeferredBodyAction<DateDifferenceCalculatorResponse>(() =>
            {
                var apiCallPath = "/dateDifferenceCalculator/";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_nonWorkingDays != null)
                    callPayload.Queries["non_working_days"] = ExpressionConverter.Convert(__workflow_nonWorkingDays);
                callPayload.Queries["working_days"] = ExpressionConverter.Convert(__workflow_workingDays);
                callPayload.Queries["start_date"] = ExpressionConverter.Convert(__workflow_startDate);
                callPayload.Queries["end_date"] = ExpressionConverter.Convert(__workflow_endDate);
                callPayload.Headers["cf"] = Convert.ToString("sk");
                return new ApiConnectionAction<DateDifferenceCalculatorResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "calculateworkingday")]
        public IBodyWorkflowAction<FirstAndLastWorkingDayOfMonthResponse> FirstAndLastWorkingDayOfMonth(Expression<Func<string>> date, Expression<Func<string>> workingDays)
        {
            var __workflow_date = date == null ? null : WorkflowExpression.Compile(date);
            WorkflowExpression.Validate(__workflow_date, nameof(date), required: true);
            var __workflow_workingDays = workingDays == null ? null : WorkflowExpression.Compile(workingDays);
            WorkflowExpression.Validate(__workflow_workingDays, nameof(workingDays), required: true);
            return new DeferredBodyAction<FirstAndLastWorkingDayOfMonthResponse>(() =>
            {
                var apiCallPath = "/firstAndLastWorkingDayOfMonth/";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["date"] = ExpressionConverter.Convert(__workflow_date);
                callPayload.Queries["working_days"] = ExpressionConverter.Convert(__workflow_workingDays);
                callPayload.Headers["cf"] = Convert.ToString("sk");
                return new ApiConnectionAction<FirstAndLastWorkingDayOfMonthResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "calculateworkingday")]
        public IBodyWorkflowAction<IsTodayAWorkingDayResponse> IsTodayAWorkingDay(Expression<Func<string>> date, Expression<Func<string>> workingDays)
        {
            var __workflow_date = date == null ? null : WorkflowExpression.Compile(date);
            WorkflowExpression.Validate(__workflow_date, nameof(date), required: true);
            var __workflow_workingDays = workingDays == null ? null : WorkflowExpression.Compile(workingDays);
            WorkflowExpression.Validate(__workflow_workingDays, nameof(workingDays), required: true);
            return new DeferredBodyAction<IsTodayAWorkingDayResponse>(() =>
            {
                var apiCallPath = "/isTodayAWorkingDay/";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["date"] = ExpressionConverter.Convert(__workflow_date);
                callPayload.Queries["working_days"] = ExpressionConverter.Convert(__workflow_workingDays);
                callPayload.Headers["cf"] = Convert.ToString("sk");
                return new ApiConnectionAction<IsTodayAWorkingDayResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "calculateworkingday")]
        public IBodyWorkflowAction<DateInXWorkingDaysResponse> DateInXWorkingDays(Expression<Func<string>> date, Expression<Func<string>> workingDays, Expression<Func<int>> xWorkingDays)
        {
            var __workflow_date = date == null ? null : WorkflowExpression.Compile(date);
            WorkflowExpression.Validate(__workflow_date, nameof(date), required: true);
            var __workflow_workingDays = workingDays == null ? null : WorkflowExpression.Compile(workingDays);
            WorkflowExpression.Validate(__workflow_workingDays, nameof(workingDays), required: true);
            var __workflow_xWorkingDays = xWorkingDays == null ? null : WorkflowExpression.Compile(xWorkingDays);
            WorkflowExpression.Validate(__workflow_xWorkingDays, nameof(xWorkingDays), required: true);
            return new DeferredBodyAction<DateInXWorkingDaysResponse>(() =>
            {
                var apiCallPath = "/dateInXWorkingDays/";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["date"] = ExpressionConverter.Convert(__workflow_date);
                callPayload.Queries["working_days"] = ExpressionConverter.Convert(__workflow_workingDays);
                callPayload.Queries["x_working_days"] = ExpressionConverter.Convert(__workflow_xWorkingDays);
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
