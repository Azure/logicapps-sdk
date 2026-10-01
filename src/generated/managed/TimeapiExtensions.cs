//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Timeapi
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class TimeapiActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "timeapi")]
        public IBodyWorkflowAction<CurrentTime> GetCurrentTime([WorkflowExpression] Func<string> timeZone)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/Time/current/zone";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["timeZone"] = SourceExpressionConverter.ConvertO(timeZone);
                return callPayload;
            }

            return new ApiConnectionAction<CurrentTime>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "timeapi")]
        public IBodyWorkflowAction<CurrentTime> GetCurrentTimeByTimezone([WorkflowExpression] Func<double> latitude, [WorkflowExpression] Func<double> longitude)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/Time/current/coordinate";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["latitude"] = SourceExpressionConverter.ConvertO(latitude);
                callPayload.Queries["longitude"] = SourceExpressionConverter.ConvertO(longitude);
                return callPayload;
            }

            return new ApiConnectionAction<CurrentTime>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "timeapi")]
        public IBodyWorkflowAction<CurrentTime> GetCurrentTimeByIp([WorkflowExpression] Func<string> ipAddress)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/Time/current/ip";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["ipAddress"] = SourceExpressionConverter.ConvertO(ipAddress);
                return callPayload;
            }

            return new ApiConnectionAction<CurrentTime>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "timeapi")]
        public IBodyWorkflowAction<string[]> ListTimezones()
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/TimeZone/AvailableTimeZones";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<string[]>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "timeapi")]
        public IBodyWorkflowAction<TimeZoneData> GetTimezone([WorkflowExpression] Func<string> timeZone)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/TimeZone/zone";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["timeZone"] = SourceExpressionConverter.ConvertO(timeZone);
                return callPayload;
            }

            return new ApiConnectionAction<TimeZoneData>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "timeapi")]
        public IBodyWorkflowAction<TimeZoneData> GetTimezoneByCoordinate([WorkflowExpression] Func<double> latitude, [WorkflowExpression] Func<double> longitude)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/TimeZone/coordinate";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["latitude"] = SourceExpressionConverter.ConvertO(latitude);
                callPayload.Queries["longitude"] = SourceExpressionConverter.ConvertO(longitude);
                return callPayload;
            }

            return new ApiConnectionAction<TimeZoneData>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "timeapi")]
        public IBodyWorkflowAction<TimeZoneData> GetTimezoneByIp([WorkflowExpression] Func<string> ipAddress)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/TimeZone/ip";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["ipAddress"] = SourceExpressionConverter.ConvertO(ipAddress);
                return callPayload;
            }

            return new ApiConnectionAction<TimeZoneData>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "timeapi")]
        public IBodyWorkflowAction<Conversion> ConvertTime([WorkflowExpression] Func<string> bodyfromTimeZone, [WorkflowExpression] Func<string> bodydateTime, [WorkflowExpression] Func<string> bodytoTimeZone, [WorkflowExpression] Func<bodydstAmbiguityInput> bodydstAmbiguity)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/Conversion/ConvertTimeZone";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["fromTimeZone"] = SourceExpressionConverter.ConvertToken(bodyfromTimeZone);
                bodypropCount++;
                body["dateTime"] = SourceExpressionConverter.ConvertToken(bodydateTime);
                bodypropCount++;
                body["toTimeZone"] = SourceExpressionConverter.ConvertToken(bodytoTimeZone);
                bodypropCount++;
                body["dstAmbiguity"] = SourceExpressionConverter.Convert(bodydstAmbiguity);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<Conversion>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "timeapi")]
        public IBodyWorkflowAction<Translation> LocalizeTime([WorkflowExpression] Func<string> bodydateTime, [WorkflowExpression] Func<string> bodylanguageCode)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/Conversion/Translate";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["dateTime"] = SourceExpressionConverter.ConvertToken(bodydateTime);
                bodypropCount++;
                body["languageCode"] = SourceExpressionConverter.ConvertToken(bodylanguageCode);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<Translation>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "timeapi")]
        public IBodyWorkflowAction<DayOfTheWeekResult> ConvertTimeToDay([WorkflowExpression] Func<string> date)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/Conversion/DayOfTheWeek/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(date, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<DayOfTheWeekResult>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "timeapi")]
        public IBodyWorkflowAction<Calculation> IncrementByTimespan([WorkflowExpression] Func<string> bodytimeZone, [WorkflowExpression] Func<string> bodydateTime, [WorkflowExpression] Func<string> bodytimeSpan, [WorkflowExpression] Func<bodydstAmbiguityInput> bodydstAmbiguity)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/Calculation/custom/increment";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["timeZone"] = SourceExpressionConverter.ConvertToken(bodytimeZone);
                bodypropCount++;
                body["dateTime"] = SourceExpressionConverter.ConvertToken(bodydateTime);
                bodypropCount++;
                body["timeSpan"] = SourceExpressionConverter.ConvertToken(bodytimeSpan);
                bodypropCount++;
                body["dstAmbiguity"] = SourceExpressionConverter.Convert(bodydstAmbiguity);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<Calculation>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "timeapi")]
        public IBodyWorkflowAction<Calculation> DecrementByTimespan([WorkflowExpression] Func<string> bodytimeZone, [WorkflowExpression] Func<string> bodydateTime, [WorkflowExpression] Func<string> bodytimeSpan, [WorkflowExpression] Func<bodydstAmbiguityInput> bodydstAmbiguity)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/Calculation/custom/decrement";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["timeZone"] = SourceExpressionConverter.ConvertToken(bodytimeZone);
                bodypropCount++;
                body["dateTime"] = SourceExpressionConverter.ConvertToken(bodydateTime);
                bodypropCount++;
                body["timeSpan"] = SourceExpressionConverter.ConvertToken(bodytimeSpan);
                bodypropCount++;
                body["dstAmbiguity"] = SourceExpressionConverter.Convert(bodydstAmbiguity);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<Calculation>(BuildSourceInput);
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