//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------
namespace Microsoft.Azure.Workflows.Sdk.Connectors.Timeapi
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;
    using System.Linq.Expressions;

    public class TimeapiActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "timeapi")]
        public IBodyWorkflowAction<CurrentTime> GetCurrentTime(Expression<Func<string>> timeZone)
        {
            var __workflow_timeZone = timeZone == null ? null : WorkflowExpression.Compile(timeZone);
            WorkflowExpression.Validate(__workflow_timeZone, nameof(timeZone), required: true);
            return new DeferredBodyAction<CurrentTime>(() =>
            {
                var apiCallPath = "/Time/current/zone";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["timeZone"] = ExpressionConverter.Convert(__workflow_timeZone);
                return new ApiConnectionAction<CurrentTime>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "timeapi")]
        public IBodyWorkflowAction<CurrentTime> GetCurrentTimeByTimezone(Expression<Func<double>> latitude, Expression<Func<double>> longitude)
        {
            var __workflow_latitude = latitude == null ? null : WorkflowExpression.Compile(latitude);
            WorkflowExpression.Validate(__workflow_latitude, nameof(latitude), required: true);
            var __workflow_longitude = longitude == null ? null : WorkflowExpression.Compile(longitude);
            WorkflowExpression.Validate(__workflow_longitude, nameof(longitude), required: true);
            return new DeferredBodyAction<CurrentTime>(() =>
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
        public IBodyWorkflowAction<CurrentTime> GetCurrentTimeByIp(Expression<Func<string>> ipAddress)
        {
            var __workflow_ipAddress = ipAddress == null ? null : WorkflowExpression.Compile(ipAddress);
            WorkflowExpression.Validate(__workflow_ipAddress, nameof(ipAddress), required: true);
            return new DeferredBodyAction<CurrentTime>(() =>
            {
                var apiCallPath = "/Time/current/ip";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["ipAddress"] = ExpressionConverter.Convert(__workflow_ipAddress);
                return new ApiConnectionAction<CurrentTime>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "timeapi")]
        public IBodyWorkflowAction<string[]> ListTimezones()
        {
            var apiCallPath = "/TimeZone/AvailableTimeZones";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<string[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "timeapi")]
        public IBodyWorkflowAction<TimeZoneData> GetTimezone(Expression<Func<string>> timeZone)
        {
            var __workflow_timeZone = timeZone == null ? null : WorkflowExpression.Compile(timeZone);
            WorkflowExpression.Validate(__workflow_timeZone, nameof(timeZone), required: true);
            return new DeferredBodyAction<TimeZoneData>(() =>
            {
                var apiCallPath = "/TimeZone/zone";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["timeZone"] = ExpressionConverter.Convert(__workflow_timeZone);
                return new ApiConnectionAction<TimeZoneData>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "timeapi")]
        public IBodyWorkflowAction<TimeZoneData> GetTimezoneByCoordinate(Expression<Func<double>> latitude, Expression<Func<double>> longitude)
        {
            var __workflow_latitude = latitude == null ? null : WorkflowExpression.Compile(latitude);
            WorkflowExpression.Validate(__workflow_latitude, nameof(latitude), required: true);
            var __workflow_longitude = longitude == null ? null : WorkflowExpression.Compile(longitude);
            WorkflowExpression.Validate(__workflow_longitude, nameof(longitude), required: true);
            return new DeferredBodyAction<TimeZoneData>(() =>
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
        public IBodyWorkflowAction<TimeZoneData> GetTimezoneByIp(Expression<Func<string>> ipAddress)
        {
            var __workflow_ipAddress = ipAddress == null ? null : WorkflowExpression.Compile(ipAddress);
            WorkflowExpression.Validate(__workflow_ipAddress, nameof(ipAddress), required: true);
            return new DeferredBodyAction<TimeZoneData>(() =>
            {
                var apiCallPath = "/TimeZone/ip";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["ipAddress"] = ExpressionConverter.Convert(__workflow_ipAddress);
                return new ApiConnectionAction<TimeZoneData>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "timeapi")]
        public IBodyWorkflowAction<Conversion> ConvertTime(Expression<Func<string>> bodyfromTimeZone, Expression<Func<string>> bodydateTime, Expression<Func<string>> bodytoTimeZone, Expression<Func<bodydstAmbiguityInput>> bodydstAmbiguity)
        {
            var __workflow_bodyfromTimeZone = bodyfromTimeZone == null ? null : WorkflowExpression.Compile(bodyfromTimeZone);
            WorkflowExpression.Validate(__workflow_bodyfromTimeZone, nameof(bodyfromTimeZone), required: true);
            var __workflow_bodydateTime = bodydateTime == null ? null : WorkflowExpression.Compile(bodydateTime);
            WorkflowExpression.Validate(__workflow_bodydateTime, nameof(bodydateTime), required: true);
            var __workflow_bodytoTimeZone = bodytoTimeZone == null ? null : WorkflowExpression.Compile(bodytoTimeZone);
            WorkflowExpression.Validate(__workflow_bodytoTimeZone, nameof(bodytoTimeZone), required: true);
            var __workflow_bodydstAmbiguity = bodydstAmbiguity == null ? null : WorkflowExpression.Compile(bodydstAmbiguity);
            WorkflowExpression.Validate(__workflow_bodydstAmbiguity, nameof(bodydstAmbiguity), required: true);
            return new DeferredBodyAction<Conversion>(() =>
            {
                var apiCallPath = "/Conversion/ConvertTimeZone";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["fromTimeZone"] = ExpressionConverter.ConvertO(__workflow_bodyfromTimeZone);
                bodypropCount++;
                body["dateTime"] = ExpressionConverter.ConvertO(__workflow_bodydateTime);
                bodypropCount++;
                body["toTimeZone"] = ExpressionConverter.ConvertO(__workflow_bodytoTimeZone);
                bodypropCount++;
                body["dstAmbiguity"] = ExpressionConverter.ConvertO(__workflow_bodydstAmbiguity);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<Conversion>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "timeapi")]
        public IBodyWorkflowAction<Translation> LocalizeTime(Expression<Func<string>> bodydateTime, Expression<Func<string>> bodylanguageCode)
        {
            var __workflow_bodydateTime = bodydateTime == null ? null : WorkflowExpression.Compile(bodydateTime);
            WorkflowExpression.Validate(__workflow_bodydateTime, nameof(bodydateTime), required: true);
            var __workflow_bodylanguageCode = bodylanguageCode == null ? null : WorkflowExpression.Compile(bodylanguageCode);
            WorkflowExpression.Validate(__workflow_bodylanguageCode, nameof(bodylanguageCode), required: true);
            return new DeferredBodyAction<Translation>(() =>
            {
                var apiCallPath = "/Conversion/Translate";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["dateTime"] = ExpressionConverter.ConvertO(__workflow_bodydateTime);
                bodypropCount++;
                body["languageCode"] = ExpressionConverter.ConvertO(__workflow_bodylanguageCode);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<Translation>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "timeapi")]
        public IBodyWorkflowAction<DayOfTheWeekResult> ConvertTimeToDay(Expression<Func<string>> date)
        {
            var __workflow_date = date == null ? null : WorkflowExpression.Compile(date);
            WorkflowExpression.Validate(__workflow_date, nameof(date), required: true);
            return new DeferredBodyAction<DayOfTheWeekResult>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/Conversion/DayOfTheWeek/{0}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_date, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<DayOfTheWeekResult>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "timeapi")]
        public IBodyWorkflowAction<Calculation> IncrementByTimespan(Expression<Func<string>> bodytimeZone, Expression<Func<string>> bodydateTime, Expression<Func<string>> bodytimeSpan, Expression<Func<bodydstAmbiguityInput>> bodydstAmbiguity)
        {
            var __workflow_bodytimeZone = bodytimeZone == null ? null : WorkflowExpression.Compile(bodytimeZone);
            WorkflowExpression.Validate(__workflow_bodytimeZone, nameof(bodytimeZone), required: true);
            var __workflow_bodydateTime = bodydateTime == null ? null : WorkflowExpression.Compile(bodydateTime);
            WorkflowExpression.Validate(__workflow_bodydateTime, nameof(bodydateTime), required: true);
            var __workflow_bodytimeSpan = bodytimeSpan == null ? null : WorkflowExpression.Compile(bodytimeSpan);
            WorkflowExpression.Validate(__workflow_bodytimeSpan, nameof(bodytimeSpan), required: true);
            var __workflow_bodydstAmbiguity = bodydstAmbiguity == null ? null : WorkflowExpression.Compile(bodydstAmbiguity);
            WorkflowExpression.Validate(__workflow_bodydstAmbiguity, nameof(bodydstAmbiguity), required: true);
            return new DeferredBodyAction<Calculation>(() =>
            {
                var apiCallPath = "/Calculation/custom/increment";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["timeZone"] = ExpressionConverter.ConvertO(__workflow_bodytimeZone);
                bodypropCount++;
                body["dateTime"] = ExpressionConverter.ConvertO(__workflow_bodydateTime);
                bodypropCount++;
                body["timeSpan"] = ExpressionConverter.ConvertO(__workflow_bodytimeSpan);
                bodypropCount++;
                body["dstAmbiguity"] = ExpressionConverter.ConvertO(__workflow_bodydstAmbiguity);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<Calculation>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "timeapi")]
        public IBodyWorkflowAction<Calculation> DecrementByTimespan(Expression<Func<string>> bodytimeZone, Expression<Func<string>> bodydateTime, Expression<Func<string>> bodytimeSpan, Expression<Func<bodydstAmbiguityInput>> bodydstAmbiguity)
        {
            var __workflow_bodytimeZone = bodytimeZone == null ? null : WorkflowExpression.Compile(bodytimeZone);
            WorkflowExpression.Validate(__workflow_bodytimeZone, nameof(bodytimeZone), required: true);
            var __workflow_bodydateTime = bodydateTime == null ? null : WorkflowExpression.Compile(bodydateTime);
            WorkflowExpression.Validate(__workflow_bodydateTime, nameof(bodydateTime), required: true);
            var __workflow_bodytimeSpan = bodytimeSpan == null ? null : WorkflowExpression.Compile(bodytimeSpan);
            WorkflowExpression.Validate(__workflow_bodytimeSpan, nameof(bodytimeSpan), required: true);
            var __workflow_bodydstAmbiguity = bodydstAmbiguity == null ? null : WorkflowExpression.Compile(bodydstAmbiguity);
            WorkflowExpression.Validate(__workflow_bodydstAmbiguity, nameof(bodydstAmbiguity), required: true);
            return new DeferredBodyAction<Calculation>(() =>
            {
                var apiCallPath = "/Calculation/custom/decrement";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["timeZone"] = ExpressionConverter.ConvertO(__workflow_bodytimeZone);
                bodypropCount++;
                body["dateTime"] = ExpressionConverter.ConvertO(__workflow_bodydateTime);
                bodypropCount++;
                body["timeSpan"] = ExpressionConverter.ConvertO(__workflow_bodytimeSpan);
                bodypropCount++;
                body["dstAmbiguity"] = ExpressionConverter.ConvertO(__workflow_bodydstAmbiguity);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum bodydstAmbiguityInput
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
