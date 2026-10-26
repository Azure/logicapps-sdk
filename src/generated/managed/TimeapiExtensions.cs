//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Timeapi
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class TimeapiActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "timeapi")]
        public IBodyWorkflowAction<CurrentTime, ApiConnectionActionConfiguration> GetCurrentTime(Expression<Func<string>> timeZone)
        {
            var __workflow_timeZone = WorkflowExpression.Compile(timeZone, nameof(timeZone), required: true);
            return new DeferredBodyAction<CurrentTime, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/Time/current/zone";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["timeZone"] = ExpressionConverter.Convert(__workflow_timeZone);
                return new ApiConnectionAction<CurrentTime>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "timeapi")]
        public IBodyWorkflowAction<CurrentTime, ApiConnectionActionConfiguration> GetCurrentTimeByTimezone(Expression<Func<double>> latitude, Expression<Func<double>> longitude)
        {
            var __workflow_latitude = WorkflowExpression.Compile(latitude, nameof(latitude), required: true);
            var __workflow_longitude = WorkflowExpression.Compile(longitude, nameof(longitude), required: true);
            return new DeferredBodyAction<CurrentTime, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/Time/current/coordinate";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["latitude"] = ExpressionConverter.Convert(__workflow_latitude);
                callPayload.Queries["longitude"] = ExpressionConverter.Convert(__workflow_longitude);
                return new ApiConnectionAction<CurrentTime>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "timeapi")]
        public IBodyWorkflowAction<CurrentTime, ApiConnectionActionConfiguration> GetCurrentTimeByIp(Expression<Func<string>> ipAddress)
        {
            var __workflow_ipAddress = WorkflowExpression.Compile(ipAddress, nameof(ipAddress), required: true);
            return new DeferredBodyAction<CurrentTime, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/Time/current/ip";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["ipAddress"] = ExpressionConverter.Convert(__workflow_ipAddress);
                return new ApiConnectionAction<CurrentTime>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "timeapi")]
        public IBodyWorkflowAction<string[], ApiConnectionActionConfiguration> ListTimezones()
        {
            return new DeferredBodyAction<string[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/TimeZone/AvailableTimeZones";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<string[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "timeapi")]
        public IBodyWorkflowAction<TimeZoneData, ApiConnectionActionConfiguration> GetTimezone(Expression<Func<string>> timeZone)
        {
            var __workflow_timeZone = WorkflowExpression.Compile(timeZone, nameof(timeZone), required: true);
            return new DeferredBodyAction<TimeZoneData, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/TimeZone/zone";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["timeZone"] = ExpressionConverter.Convert(__workflow_timeZone);
                return new ApiConnectionAction<TimeZoneData>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "timeapi")]
        public IBodyWorkflowAction<TimeZoneData, ApiConnectionActionConfiguration> GetTimezoneByCoordinate(Expression<Func<double>> latitude, Expression<Func<double>> longitude)
        {
            var __workflow_latitude = WorkflowExpression.Compile(latitude, nameof(latitude), required: true);
            var __workflow_longitude = WorkflowExpression.Compile(longitude, nameof(longitude), required: true);
            return new DeferredBodyAction<TimeZoneData, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/TimeZone/coordinate";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["latitude"] = ExpressionConverter.Convert(__workflow_latitude);
                callPayload.Queries["longitude"] = ExpressionConverter.Convert(__workflow_longitude);
                return new ApiConnectionAction<TimeZoneData>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "timeapi")]
        public IBodyWorkflowAction<TimeZoneData, ApiConnectionActionConfiguration> GetTimezoneByIp(Expression<Func<string>> ipAddress)
        {
            var __workflow_ipAddress = WorkflowExpression.Compile(ipAddress, nameof(ipAddress), required: true);
            return new DeferredBodyAction<TimeZoneData, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/TimeZone/ip";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["ipAddress"] = ExpressionConverter.Convert(__workflow_ipAddress);
                return new ApiConnectionAction<TimeZoneData>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "timeapi")]
        public IBodyWorkflowAction<Conversion, ApiConnectionActionConfiguration> ConvertTime(Expression<Func<ConvertTimeInput>> body = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<Conversion, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/Conversion/ConvertTimeZone";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<Conversion>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "timeapi")]
        public IBodyWorkflowAction<Translation, ApiConnectionActionConfiguration> LocalizeTime(Expression<Func<LocalizeTimeInput>> body = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<Translation, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/Conversion/Translate";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<Translation>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "timeapi")]
        public IBodyWorkflowAction<DayOfTheWeekResult, ApiConnectionActionConfiguration> ConvertTimeToDay(Expression<Func<string>> date)
        {
            var __workflow_date = WorkflowExpression.Compile(date, nameof(date), required: true);
            return new DeferredBodyAction<DayOfTheWeekResult, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/Conversion/DayOfTheWeek/{0}", __workflow_date.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<DayOfTheWeekResult>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "timeapi")]
        public IBodyWorkflowAction<Calculation, ApiConnectionActionConfiguration> IncrementByTimespan(Expression<Func<IncrementByTimespanInput>> body = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<Calculation, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/Calculation/custom/increment";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<Calculation>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "timeapi")]
        public IBodyWorkflowAction<Calculation, ApiConnectionActionConfiguration> DecrementByTimespan(Expression<Func<DecrementByTimespanInput>> body = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<Calculation, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/Calculation/custom/decrement";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<Calculation>(callPayload);
            });
        }
    }

    public class TimeapiTriggers([ConnectionName] string connectionId)
    {
    }

    public class CurrentTime
    {
        [JsonProperty("year")]
        public int Year { get; set; }

        [JsonProperty("month")]
        public int Month { get; set; }

        [JsonProperty("day")]
        public int Day { get; set; }

        [JsonProperty("hour")]
        public int Hour { get; set; }

        [JsonProperty("minute")]
        public int Minute { get; set; }

        [JsonProperty("seconds")]
        public int Seconds { get; set; }

        [JsonProperty("milliSeconds")]
        public int MilliSeconds { get; set; }

        [JsonProperty("dateTime")]
        public string DateTime { get; set; }

        [JsonProperty("date")]
        public string Date { get; set; }

        [JsonProperty("time")]
        public string Time { get; set; }

        [JsonProperty("timeZone")]
        public string TimeZone { get; set; }

        [JsonProperty("dayOfWeek")]
        public DayOfWeek DayOfWeek { get; set; }

        [JsonProperty("dstActive")]
        public bool DstActive { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum DayOfWeek
    {
        Sunday,
        Monday,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday
    }

    public class TimeZoneData
    {
        [JsonProperty("timeZone")]
        public string TimeZone { get; set; }

        [JsonProperty("currentLocalTime")]
        public string CurrentLocalTime { get; set; }

        [JsonProperty("currentUtcOffset")]
        public Offset CurrentUtcOffset { get; set; }

        [JsonProperty("standardUtcOffset")]
        public Offset StandardUtcOffset { get; set; }

        [JsonProperty("hasDayLightSaving")]
        public bool HasDayLightSaving { get; set; }

        [JsonProperty("isDayLightSavingActive")]
        public bool IsDayLightSavingActive { get; set; }

        [JsonProperty("dstInterval")]
        public DstInterval DstInterval { get; set; }
    }

    public class Offset
    {
        [JsonProperty("seconds")]
        public int Seconds { get; set; }

        [JsonProperty("milliseconds")]
        public int Milliseconds { get; set; }

        [JsonProperty("ticks")]
        public int Ticks { get; set; }

        [JsonProperty("nanoseconds")]
        public int Nanoseconds { get; set; }
    }

    public class DstInterval
    {
        [JsonProperty("dstName")]
        public string DstName { get; set; }

        [JsonProperty("dstOffsetToUtc")]
        public Offset DstOffsetToUtc { get; set; }

        [JsonProperty("dstOffsetToStandardTime")]
        public Offset DstOffsetToStandardTime { get; set; }

        [JsonProperty("dstStart")]
        public string DstStart { get; set; }

        [JsonProperty("dstEnd")]
        public string DstEnd { get; set; }

        [JsonProperty("dstDuration")]
        public Duration DstDuration { get; set; }
    }

    public class Duration
    {
        [JsonProperty("days")]
        public int Days { get; set; }

        [JsonProperty("nanosecondOfDay")]
        public int NanosecondOfDay { get; set; }

        [JsonProperty("hours")]
        public int Hours { get; set; }

        [JsonProperty("minutes")]
        public int Minutes { get; set; }

        [JsonProperty("seconds")]
        public int Seconds { get; set; }

        [JsonProperty("milliseconds")]
        public int Milliseconds { get; set; }

        [JsonProperty("subsecondTicks")]
        public int SubsecondTicks { get; set; }

        [JsonProperty("subsecondNanoseconds")]
        public int SubsecondNanoseconds { get; set; }

        [JsonProperty("bclCompatibleTicks")]
        public int BclCompatibleTicks { get; set; }

        [JsonProperty("totalDays")]
        public double TotalDays { get; set; }

        [JsonProperty("totalHours")]
        public double TotalHours { get; set; }

        [JsonProperty("totalMinutes")]
        public double TotalMinutes { get; set; }

        [JsonProperty("totalSeconds")]
        public double TotalSeconds { get; set; }

        [JsonProperty("totalMilliseconds")]
        public double TotalMilliseconds { get; set; }

        [JsonProperty("totalTicks")]
        public double TotalTicks { get; set; }

        [JsonProperty("totalNanoseconds")]
        public double TotalNanoseconds { get; set; }
    }

    public class Conversion
    {
        [JsonProperty("fromTimezone")]
        public string FromTimezone { get; set; }

        [JsonProperty("fromDateTime")]
        public string FromDateTime { get; set; }

        [JsonProperty("toTimeZone")]
        public string ToTimeZone { get; set; }

        [JsonProperty("conversionResult")]
        public ConversionResult ConversionResult { get; set; }
    }

    public class ConversionResult
    {
        [JsonProperty("year")]
        public int Year { get; set; }

        [JsonProperty("month")]
        public int Month { get; set; }

        [JsonProperty("day")]
        public int Day { get; set; }

        [JsonProperty("hour")]
        public int Hour { get; set; }

        [JsonProperty("minute")]
        public int Minute { get; set; }

        [JsonProperty("seconds")]
        public int Seconds { get; set; }

        [JsonProperty("milliSeconds")]
        public int MilliSeconds { get; set; }

        [JsonProperty("dateTime")]
        public string DateTime { get; set; }

        [JsonProperty("date")]
        public string Date { get; set; }

        [JsonProperty("time")]
        public string Time { get; set; }

        [JsonProperty("timeZone")]
        public string TimeZone { get; set; }

        [JsonProperty("dstActive")]
        public bool DstActive { get; set; }
    }

    public class ConvertTimeInput
    {
        [JsonProperty("fromTimeZone", DefaultValueHandling = DefaultValueHandling.Include)]
        public string FromTimeZone { get; set; }

        [JsonProperty("dateTime", DefaultValueHandling = DefaultValueHandling.Include)]
        public string DateTime { get; set; }

        [JsonProperty("toTimeZone", DefaultValueHandling = DefaultValueHandling.Include)]
        public string ToTimeZone { get; set; }

        [JsonProperty("dstAmbiguity", DefaultValueHandling = DefaultValueHandling.Include)]
        public ConvertTimeInputDstAmbiguityType DstAmbiguity { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum ConvertTimeInputDstAmbiguityType
    {
        [EnumMember(Value = "earlier")]
        Earlier,
        [EnumMember(Value = "later")]
        Later
    }

    public class Translation
    {
        [JsonProperty("dateTime")]
        public string DateTime { get; set; }

        [JsonProperty("languageCode")]
        public string LanguageCode { get; set; }

        [JsonProperty("friendlyDateTime")]
        public string FriendlyDateTime { get; set; }

        [JsonProperty("friendlyDate")]
        public string FriendlyDate { get; set; }

        [JsonProperty("friendlyTime")]
        public string FriendlyTime { get; set; }
    }

    public class LocalizeTimeInput
    {
        [JsonProperty("dateTime", DefaultValueHandling = DefaultValueHandling.Include)]
        public string DateTime { get; set; }

        [JsonProperty("languageCode", DefaultValueHandling = DefaultValueHandling.Include)]
        public string LanguageCode { get; set; }
    }

    public class DayOfTheWeekResult
    {
        [JsonProperty("dayOfWeek")]
        public DayOfWeek DayOfWeek { get; set; }
    }

    public class Calculation
    {
        [JsonProperty("timeZone")]
        public string TimeZone { get; set; }

        [JsonProperty("originalDateTime")]
        public string OriginalDateTime { get; set; }

        [JsonProperty("usedTimeSpan")]
        public string UsedTimeSpan { get; set; }

        [JsonProperty("calculationResult")]
        public CalculationResult CalculationResult { get; set; }
    }

    public class CalculationResult
    {
        [JsonProperty("year")]
        public int Year { get; set; }

        [JsonProperty("month")]
        public int Month { get; set; }

        [JsonProperty("day")]
        public int Day { get; set; }

        [JsonProperty("hour")]
        public int Hour { get; set; }

        [JsonProperty("minute")]
        public int Minute { get; set; }

        [JsonProperty("seconds")]
        public int Seconds { get; set; }

        [JsonProperty("milliSeconds")]
        public int MilliSeconds { get; set; }

        [JsonProperty("dateTime")]
        public string DateTime { get; set; }

        [JsonProperty("date")]
        public string Date { get; set; }

        [JsonProperty("time")]
        public string Time { get; set; }

        [JsonProperty("dstActive")]
        public bool DstActive { get; set; }
    }

    public class IncrementByTimespanInput
    {
        [JsonProperty("timeZone", DefaultValueHandling = DefaultValueHandling.Include)]
        public string TimeZone { get; set; }

        [JsonProperty("dateTime", DefaultValueHandling = DefaultValueHandling.Include)]
        public string DateTime { get; set; }

        [JsonProperty("timeSpan", DefaultValueHandling = DefaultValueHandling.Include)]
        public string TimeSpan { get; set; }

        [JsonProperty("dstAmbiguity", DefaultValueHandling = DefaultValueHandling.Include)]
        public IncrementByTimespanInputDstAmbiguityType DstAmbiguity { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum IncrementByTimespanInputDstAmbiguityType
    {
        [EnumMember(Value = "earlier")]
        Earlier,
        [EnumMember(Value = "later")]
        Later
    }

    public class DecrementByTimespanInput
    {
        [JsonProperty("timeZone", DefaultValueHandling = DefaultValueHandling.Include)]
        public string TimeZone { get; set; }

        [JsonProperty("dateTime", DefaultValueHandling = DefaultValueHandling.Include)]
        public string DateTime { get; set; }

        [JsonProperty("timeSpan", DefaultValueHandling = DefaultValueHandling.Include)]
        public string TimeSpan { get; set; }

        [JsonProperty("dstAmbiguity", DefaultValueHandling = DefaultValueHandling.Include)]
        public DecrementByTimespanInputDstAmbiguityType DstAmbiguity { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum DecrementByTimespanInputDstAmbiguityType
    {
        [EnumMember(Value = "earlier")]
        Earlier,
        [EnumMember(Value = "later")]
        Later
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Timeapi;

    public partial class WorkflowManagedActions
    {
        public TimeapiActions Timeapi(string connectionId) => new TimeapiActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public TimeapiTriggers Timeapi(string connectionId) => new TimeapiTriggers(connectionId);
    }
}