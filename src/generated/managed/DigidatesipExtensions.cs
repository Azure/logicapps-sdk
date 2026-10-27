//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Digidatesip
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class DigidatesipActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "digidatesip")]
        public IBodyWorkflowAction<UnixGetResponse, ApiConnectionActionConfiguration> UnixGet(Expression<Func<string>> timestamp)
        {
            var __workflow_timestamp = WorkflowExpression.Compile(timestamp, nameof(timestamp), required: true);
            return new DeferredBodyAction<UnixGetResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/unixtime";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["timestamp"] = ExpressionConverter.Convert(__workflow_timestamp);
                return new ApiConnectionAction<UnixGetResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "digidatesip")]
        public IBodyWorkflowAction<DateValidateGetResponse, ApiConnectionActionConfiguration> DateValidateGet(Expression<Func<string>> date)
        {
            var __workflow_date = WorkflowExpression.Compile(date, nameof(date), required: true);
            return new DeferredBodyAction<DateValidateGetResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/checkdate";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["date"] = ExpressionConverter.Convert(__workflow_date);
                return new ApiConnectionAction<DateValidateGetResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "digidatesip")]
        public IBodyWorkflowAction<CalendarWeekGetResponse, ApiConnectionActionConfiguration> CalendarWeekGet(Expression<Func<string>> date)
        {
            var __workflow_date = WorkflowExpression.Compile(date, nameof(date), required: true);
            return new DeferredBodyAction<CalendarWeekGetResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/week";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["date"] = ExpressionConverter.Convert(__workflow_date);
                return new ApiConnectionAction<CalendarWeekGetResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "digidatesip")]
        public IBodyWorkflowAction<LeapYearGetResponse, ApiConnectionActionConfiguration> LeapYearGet(Expression<Func<int>> year)
        {
            var __workflow_year = WorkflowExpression.Compile(year, nameof(year), required: true);
            return new DeferredBodyAction<LeapYearGetResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/leapyear";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["year"] = ExpressionConverter.Convert(__workflow_year);
                return new ApiConnectionAction<LeapYearGetResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "digidatesip")]
        public IBodyWorkflowAction<AgeGetResponse, ApiConnectionActionConfiguration> AgeGet(Expression<Func<string>> date)
        {
            var __workflow_date = WorkflowExpression.Compile(date, nameof(date), required: true);
            return new DeferredBodyAction<AgeGetResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/age/{0}", __workflow_date.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<AgeGetResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "digidatesip")]
        public IBodyWorkflowAction<CountdownGetResponse, ApiConnectionActionConfiguration> CountdownGet(Expression<Func<string>> date)
        {
            var __workflow_date = WorkflowExpression.Compile(date, nameof(date), required: true);
            return new DeferredBodyAction<CountdownGetResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/countdown/{0}", __workflow_date.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<CountdownGetResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "digidatesip")]
        public IBodyWorkflowAction<ProgressGetResponse, ApiConnectionActionConfiguration> ProgressGet(Expression<Func<string>> start, Expression<Func<string>> end)
        {
            var __workflow_start = WorkflowExpression.Compile(start, nameof(start), required: true);
            var __workflow_end = WorkflowExpression.Compile(end, nameof(end), required: true);
            return new DeferredBodyAction<ProgressGetResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/progress";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["start"] = ExpressionConverter.Convert(__workflow_start);
                callPayload.Queries["end"] = ExpressionConverter.Convert(__workflow_end);
                return new ApiConnectionAction<ProgressGetResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "digidatesip")]
        public IBodyWorkflowAction<CO2GetResponse, ApiConnectionActionConfiguration> CO2Get(Expression<Func<string>> year)
        {
            var __workflow_year = WorkflowExpression.Compile(year, nameof(year), required: true);
            return new DeferredBodyAction<CO2GetResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/co2/{0}", __workflow_year.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<CO2GetResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "digidatesip")]
        public IBodyWorkflowAction<CO2ValueGetResponse, ApiConnectionActionConfiguration> CO2ValueGet(Expression<Func<double>> value)
        {
            var __workflow_value = WorkflowExpression.Compile(value, nameof(value), required: true);
            return new DeferredBodyAction<CO2ValueGetResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/co2/reverse/{0}", __workflow_value.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<CO2ValueGetResponse>(callPayload);
            });
        }
    }

    public class DigidatesipTriggers([ConnectionName] string connectionId)
    {
    }

    public class UnixGetResponse
    {
        [JsonProperty("time")]
        public int Time { get; set; }
    }

    public class DateValidateGetResponse
    {
        [JsonProperty("checkdate")]
        public bool Checkdate { get; set; }
    }

    public class CalendarWeekGetResponse
    {
        [JsonProperty("week")]
        public int Week { get; set; }
    }

    public class LeapYearGetResponse
    {
        [JsonProperty("leapyear")]
        public bool Leapyear { get; set; }
    }

    public class AgeGetResponse
    {
        [JsonProperty("age")]
        public int Age { get; set; }

        [JsonProperty("ageextended")]
        public AgeGetResponseAgeextendedType Ageextended { get; set; }
    }

    public class AgeGetResponseAgeextendedType
    {
        [JsonProperty("years")]
        public int Years { get; set; }

        [JsonProperty("months")]
        public int Months { get; set; }

        [JsonProperty("days")]
        public int Days { get; set; }
    }

    public class CountdownGetResponse
    {
        [JsonProperty("daysonly")]
        public int Daysonly { get; set; }

        [JsonProperty("countdownextended")]
        public CountdownGetResponseCountdownextendedType Countdownextended { get; set; }
    }

    public class CountdownGetResponseCountdownextendedType
    {
        [JsonProperty("years")]
        public int Years { get; set; }

        [JsonProperty("months")]
        public int Months { get; set; }

        [JsonProperty("days")]
        public int Days { get; set; }
    }

    public class ProgressGetResponse
    {
        [JsonProperty("float")]
        public double Float { get; set; }

        [JsonProperty("percent")]
        public int Percent { get; set; }
    }

    public class CO2GetResponse
    {
        [JsonProperty("co2")]
        public double Co2 { get; set; }
    }

    public class CO2ValueGetResponse
    {
        [JsonProperty("year")]
        public int Year { get; set; }

        [JsonProperty("co2")]
        public double Co2 { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Digidatesip;

    public partial class WorkflowManagedActions
    {
        public DigidatesipActions Digidatesip(string connectionId) => new DigidatesipActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public DigidatesipTriggers Digidatesip(string connectionId) => new DigidatesipTriggers(connectionId);
    }
}