//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Calculateworkingday
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class CalculateworkingdayActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "calculateworkingday")]
        public IBodyWorkflowAction<CombinedResponse> Combined([WorkflowExpression] Func<string> date, [WorkflowExpression] Func<string> workingDays, [WorkflowExpression] Func<int> xWorkingDays, [WorkflowExpression] Func<string> nonWorkingDays = null, [WorkflowExpression] Func<string> country = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/combined/";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["date"] = SourceExpressionConverter.ConvertO(date);
                callPayload.Queries["working_days"] = SourceExpressionConverter.ConvertO(workingDays);
                if (nonWorkingDays != null)
                    callPayload.Queries["non_working_days"] = SourceExpressionConverter.ConvertO(nonWorkingDays);
                callPayload.Queries["x_working_days"] = SourceExpressionConverter.ConvertO(xWorkingDays);
                callPayload.Queries["country"] = Convert.ToString("scotland");
                if (country != null)
                    callPayload.Queries["country"] = SourceExpressionConverter.ConvertO(country);
                callPayload.Headers["cf"] = Convert.ToString("sk");
                return callPayload;
            }

            return new ApiConnectionAction<CombinedResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "calculateworkingday")]
        public IBodyWorkflowAction<BasicNextWorkingDayResponse> BasicNextWorkingDay([WorkflowExpression] Func<string> date)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/basicNextWorkingDay/";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["date"] = SourceExpressionConverter.ConvertO(date);
                callPayload.Headers["cf"] = Convert.ToString("sk");
                return callPayload;
            }

            return new ApiConnectionAction<BasicNextWorkingDayResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "calculateworkingday")]
        public IBodyWorkflowAction<NextWorkingDayResponse> NextWorkingDay([WorkflowExpression] Func<string> date, [WorkflowExpression] Func<string> workingDays, [WorkflowExpression] Func<int> xWorkingDays, [WorkflowExpression] Func<string> nonWorkingDays = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/nextWorkingDay/";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["date"] = SourceExpressionConverter.ConvertO(date);
                callPayload.Queries["working_days"] = SourceExpressionConverter.ConvertO(workingDays);
                if (nonWorkingDays != null)
                    callPayload.Queries["non_working_days"] = SourceExpressionConverter.ConvertO(nonWorkingDays);
                callPayload.Queries["x_working_days"] = SourceExpressionConverter.ConvertO(xWorkingDays);
                callPayload.Headers["cf"] = Convert.ToString("sk");
                return callPayload;
            }

            return new ApiConnectionAction<NextWorkingDayResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "calculateworkingday")]
        public IBodyWorkflowAction<DateDifferenceCalculatorResponse> DateDifferenceCalculator([WorkflowExpression] Func<string> workingDays, [WorkflowExpression] Func<string> startDate, [WorkflowExpression] Func<string> endDate, [WorkflowExpression] Func<string> nonWorkingDays = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/dateDifferenceCalculator/";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (nonWorkingDays != null)
                    callPayload.Queries["non_working_days"] = SourceExpressionConverter.ConvertO(nonWorkingDays);
                callPayload.Queries["working_days"] = SourceExpressionConverter.ConvertO(workingDays);
                callPayload.Queries["start_date"] = SourceExpressionConverter.ConvertO(startDate);
                callPayload.Queries["end_date"] = SourceExpressionConverter.ConvertO(endDate);
                callPayload.Headers["cf"] = Convert.ToString("sk");
                return callPayload;
            }

            return new ApiConnectionAction<DateDifferenceCalculatorResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "calculateworkingday")]
        public IBodyWorkflowAction<FirstAndLastWorkingDayOfMonthResponse> FirstAndLastWorkingDayOfMonth([WorkflowExpression] Func<string> date, [WorkflowExpression] Func<string> workingDays)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/firstAndLastWorkingDayOfMonth/";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["date"] = SourceExpressionConverter.ConvertO(date);
                callPayload.Queries["working_days"] = SourceExpressionConverter.ConvertO(workingDays);
                callPayload.Headers["cf"] = Convert.ToString("sk");
                return callPayload;
            }

            return new ApiConnectionAction<FirstAndLastWorkingDayOfMonthResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "calculateworkingday")]
        public IBodyWorkflowAction<IsTodayAWorkingDayResponse> IsTodayAWorkingDay([WorkflowExpression] Func<string> date, [WorkflowExpression] Func<string> workingDays)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/isTodayAWorkingDay/";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["date"] = SourceExpressionConverter.ConvertO(date);
                callPayload.Queries["working_days"] = SourceExpressionConverter.ConvertO(workingDays);
                callPayload.Headers["cf"] = Convert.ToString("sk");
                return callPayload;
            }

            return new ApiConnectionAction<IsTodayAWorkingDayResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "calculateworkingday")]
        public IBodyWorkflowAction<DateInXWorkingDaysResponse> DateInXWorkingDays([WorkflowExpression] Func<string> date, [WorkflowExpression] Func<string> workingDays, [WorkflowExpression] Func<int> xWorkingDays)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/dateInXWorkingDays/";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["date"] = SourceExpressionConverter.ConvertO(date);
                callPayload.Queries["working_days"] = SourceExpressionConverter.ConvertO(workingDays);
                callPayload.Queries["x_working_days"] = SourceExpressionConverter.ConvertO(xWorkingDays);
                callPayload.Headers["cf"] = Convert.ToString("sk");
                return callPayload;
            }

            return new ApiConnectionAction<DateInXWorkingDaysResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "calculateworkingday")]
        public IBodyWorkflowAction<CountryResponse> Country()
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/bank-holidays.json";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<CountryResponse>(BuildSourceInput);
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