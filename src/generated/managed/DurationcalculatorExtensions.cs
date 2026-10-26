//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Durationcalculator
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class DurationcalculatorActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "durationcalculator")]
        public IBodyWorkflowAction<BusinessDaysResponse, ApiConnectionActionConfiguration> CalculateBusinessDays(Expression<Func<CalculateBusinessDaysInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<BusinessDaysResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/CalculateBusinessDays";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<BusinessDaysResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "durationcalculator")]
        public IBodyWorkflowAction<AgeCalculationResponse, ApiConnectionActionConfiguration> CalculateAge(Expression<Func<CalculateAgeInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<AgeCalculationResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/CalculateAge";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<AgeCalculationResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "durationcalculator")]
        public IBodyWorkflowAction<WorkingHoursResponse, ApiConnectionActionConfiguration> CalculateWorkingHours(Expression<Func<CalculateWorkingHoursInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<WorkingHoursResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/CalculateWorkingHours";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<WorkingHoursResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "durationcalculator")]
        public IBodyWorkflowAction<TimeZoneConversionResponse, ApiConnectionActionConfiguration> ConvertTimeZones(Expression<Func<ConvertTimeZonesInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<TimeZoneConversionResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/ConvertTimeZones";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<TimeZoneConversionResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "durationcalculator")]
        public IBodyWorkflowAction<ProjectDurationResponse, ApiConnectionActionConfiguration> CalculateProjectDuration(Expression<Func<CalculateProjectDurationInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<ProjectDurationResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/CalculateProjectDuration";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<ProjectDurationResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "durationcalculator")]
        public IBodyWorkflowAction<PayrollPeriodsResponse, ApiConnectionActionConfiguration> CalculatePayrollPeriods(Expression<Func<CalculatePayrollPeriodsInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<PayrollPeriodsResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/CalculatePayrollPeriods";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<PayrollPeriodsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "durationcalculator")]
        public IBodyWorkflowAction<TimeZoneInfoResponse, ApiConnectionActionConfiguration> GetTimeZoneInfo(Expression<Func<GetTimeZoneInfoInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<TimeZoneInfoResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/GetTimeZoneInfo";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<TimeZoneInfoResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "durationcalculator")]
        public IBodyWorkflowAction<DeadlineCalculationResponse, ApiConnectionActionConfiguration> DeadlineCalculation(Expression<Func<DeadlineCalculationInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<DeadlineCalculationResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/DeadlineCalculation";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<DeadlineCalculationResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "durationcalculator")]
        public IBodyWorkflowAction<CrossTzDurationResponse, ApiConnectionActionConfiguration> CrossTzDuration(Expression<Func<CrossTzDurationInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<CrossTzDurationResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/CrossTzDuration";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<CrossTzDurationResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "durationcalculator")]
        public IBodyWorkflowAction<GlobalWorkingHoursResponse, ApiConnectionActionConfiguration> CalculateGlobalWorkingHours(Expression<Func<CalculateGlobalWorkingHoursInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<GlobalWorkingHoursResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/CalculateGlobalWorkingHours";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<GlobalWorkingHoursResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "durationcalculator")]
        public IBodyWorkflowAction<MeetingTimesResponse, ApiConnectionActionConfiguration> CalculateMeetingTimes(Expression<Func<CalculateMeetingTimesInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<MeetingTimesResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/CalculateMeetingTimes";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<MeetingTimesResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "durationcalculator")]
        public IBodyWorkflowAction<DstValidationResponse, ApiConnectionActionConfiguration> ValidateDstCalculations(Expression<Func<ValidateDstCalculationsInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<DstValidationResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/ValidateDstCalculations";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<DstValidationResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "durationcalculator")]
        public IBodyWorkflowAction<DstTransitionResponse, ApiConnectionActionConfiguration> CalculateDstTransition(Expression<Func<CalculateDstTransitionInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<DstTransitionResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/CalculateDstTransition";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<DstTransitionResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "durationcalculator")]
        public IBodyWorkflowAction<DstHistoryResponse, ApiConnectionActionConfiguration> GetDstHistory(Expression<Func<GetDstHistoryInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<DstHistoryResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/GetDstHistory";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<DstHistoryResponse>(callPayload);
            });
        }
    }

    public class DurationcalculatorTriggers([ConnectionName] string connectionId)
    {
    }

    public class BusinessDaysResponse
    {
        [JsonProperty("startDate")]
        public string StartDate { get; set; }

        [JsonProperty("endDate")]
        public string EndDate { get; set; }

        [JsonProperty("businessDays")]
        public int BusinessDays { get; set; }

        [JsonProperty("totalDays")]
        public int TotalDays { get; set; }

        [JsonProperty("weekendDays")]
        public int WeekendDays { get; set; }

        [JsonProperty("holidayDays")]
        public int HolidayDays { get; set; }

        [JsonProperty("holidaysInRange")]
        public string[] HolidaysInRange { get; set; }
    }

    public class CalculateBusinessDaysInput
    {
        [JsonProperty("startDate", DefaultValueHandling = DefaultValueHandling.Include)]
        public string StartDate { get; set; }

        [JsonProperty("endDate", DefaultValueHandling = DefaultValueHandling.Include)]
        public string EndDate { get; set; }

        [JsonProperty("holidays")]
        public string[] Holidays { get; set; }

        [JsonProperty("includeStartDate", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? IncludeStartDate { get; set; } = true;
    }

    public class AgeCalculationResponse
    {
        [JsonProperty("birthDate")]
        public string BirthDate { get; set; }

        [JsonProperty("calculationDate")]
        public string CalculationDate { get; set; }

        [JsonProperty("ageYears")]
        public int AgeYears { get; set; }

        [JsonProperty("ageMonths")]
        public int AgeMonths { get; set; }

        [JsonProperty("ageDays")]
        public int AgeDays { get; set; }

        [JsonProperty("totalDays")]
        public int TotalDays { get; set; }

        [JsonProperty("totalHours")]
        public int TotalHours { get; set; }

        [JsonProperty("totalMinutes")]
        public int TotalMinutes { get; set; }

        [JsonProperty("formattedAge")]
        public string FormattedAge { get; set; }
    }

    public class CalculateAgeInput
    {
        [JsonProperty("birthDate", DefaultValueHandling = DefaultValueHandling.Include)]
        public string BirthDate { get; set; }

        [JsonProperty("asOfDate")]
        public string AsOfDate { get; set; }

        [JsonProperty("includeTime", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? IncludeTime { get; set; } = false;
    }

    public class WorkingHoursResponse
    {
        [JsonProperty("startDateTime")]
        public string StartDateTime { get; set; }

        [JsonProperty("endDateTime")]
        public string EndDateTime { get; set; }

        [JsonProperty("totalHours")]
        public double TotalHours { get; set; }

        [JsonProperty("regularHours")]
        public double RegularHours { get; set; }

        [JsonProperty("overtimeHours")]
        public double OvertimeHours { get; set; }

        [JsonProperty("totalDays")]
        public int TotalDays { get; set; }

        [JsonProperty("workingDays")]
        public int WorkingDays { get; set; }
    }

    public class CalculateWorkingHoursInput
    {
        [JsonProperty("startDateTime", DefaultValueHandling = DefaultValueHandling.Include)]
        public string StartDateTime { get; set; }

        [JsonProperty("endDateTime", DefaultValueHandling = DefaultValueHandling.Include)]
        public string EndDateTime { get; set; }

        [JsonProperty("workingHours")]
        public CalculateWorkingHoursInputWorkingHoursType WorkingHours { get; set; }

        [JsonProperty("overtimeRate", DefaultValueHandling = DefaultValueHandling.Include)]
        public double? OvertimeRate { get; set; } = 1.5;

        [JsonProperty("breakHours", DefaultValueHandling = DefaultValueHandling.Include)]
        public double? BreakHours { get; set; } = 1;
    }

    public class CalculateWorkingHoursInputWorkingHoursType
    {
        [JsonProperty("start")]
        public string Start { get; set; }

        [JsonProperty("end")]
        public string End { get; set; }
    }

    public class TimeZoneConversionResponse
    {
        [JsonProperty("originalDateTime")]
        public string OriginalDateTime { get; set; }

        [JsonProperty("convertedDateTime")]
        public string ConvertedDateTime { get; set; }

        [JsonProperty("fromTimeZone")]
        public string FromTimeZone { get; set; }

        [JsonProperty("toTimeZone")]
        public string ToTimeZone { get; set; }

        [JsonProperty("offsetDifference")]
        public string OffsetDifference { get; set; }

        [JsonProperty("isDstActive")]
        public bool IsDstActive { get; set; }
    }

    public class ConvertTimeZonesInput
    {
        [JsonProperty("dateTime", DefaultValueHandling = DefaultValueHandling.Include)]
        public string DateTime { get; set; }

        [JsonProperty("fromTimeZone", DefaultValueHandling = DefaultValueHandling.Include)]
        public TimeZoneEnum FromTimeZone { get; set; }

        [JsonProperty("toTimeZone", DefaultValueHandling = DefaultValueHandling.Include)]
        public TimeZoneEnum ToTimeZone { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum TimeZoneEnum
    {
        [EnumMember(Value = "Pacific/Fiji")]
        PacificFiji,
        [EnumMember(Value = "Pacific/Auckland")]
        PacificAuckland,
        [EnumMember(Value = "Asia/Magadan")]
        AsiaMagadan,
        [EnumMember(Value = "Asia/Vladivostok")]
        AsiaVladivostok,
        [EnumMember(Value = "Australia/Hobart")]
        AustraliaHobart,
        [EnumMember(Value = "Australia/Melbourne")]
        AustraliaMelbourne,
        [EnumMember(Value = "Australia/Sydney")]
        AustraliaSydney,
        [EnumMember(Value = "Australia/Brisbane")]
        AustraliaBrisbane,
        [EnumMember(Value = "Australia/Adelaide")]
        AustraliaAdelaide,
        [EnumMember(Value = "Australia/Darwin")]
        AustraliaDarwin,
        [EnumMember(Value = "Asia/Irkutsk")]
        AsiaIrkutsk,
        [EnumMember(Value = "Asia/Krasnoyarsk")]
        AsiaKrasnoyarsk,
        [EnumMember(Value = "Asia/Tokyo")]
        AsiaTokyo,
        [EnumMember(Value = "Asia/Seoul")]
        AsiaSeoul,
        [EnumMember(Value = "Australia/Perth")]
        AustraliaPerth,
        [EnumMember(Value = "Asia/Kuala_Lumpur")]
        AsiaKualaLumpur,
        [EnumMember(Value = "Asia/Singapore")]
        AsiaSingapore,
        [EnumMember(Value = "Asia/Manila")]
        AsiaManila,
        [EnumMember(Value = "Asia/Taipei")]
        AsiaTaipei,
        [EnumMember(Value = "Asia/Hong_Kong")]
        AsiaHongKong,
        [EnumMember(Value = "Asia/Shanghai")]
        AsiaShanghai,
        [EnumMember(Value = "Asia/Novosibirsk")]
        AsiaNovosibirsk,
        [EnumMember(Value = "Asia/Almaty")]
        AsiaAlmaty,
        [EnumMember(Value = "Asia/Jakarta")]
        AsiaJakarta,
        [EnumMember(Value = "Asia/Phnom_Penh")]
        AsiaPhnomPenh,
        [EnumMember(Value = "Asia/Ho_Chi_Minh")]
        AsiaHoChiMinh,
        [EnumMember(Value = "Asia/Bangkok")]
        AsiaBangkok,
        [EnumMember(Value = "Asia/Yangon")]
        AsiaYangon,
        [EnumMember(Value = "Asia/Dhaka")]
        AsiaDhaka,
        [EnumMember(Value = "Asia/Kolkata")]
        AsiaKolkata,
        [EnumMember(Value = "Asia/Tashkent")]
        AsiaTashkent,
        [EnumMember(Value = "Asia/Karachi")]
        AsiaKarachi,
        [EnumMember(Value = "Indian/Maldives")]
        IndianMaldives,
        [EnumMember(Value = "Indian/Mauritius")]
        IndianMauritius,
        [EnumMember(Value = "Asia/Dubai")]
        AsiaDubai,
        [EnumMember(Value = "Asia/Tehran")]
        AsiaTehran,
        [EnumMember(Value = "Asia/Baghdad")]
        AsiaBaghdad,
        [EnumMember(Value = "Asia/Kuwait")]
        AsiaKuwait,
        [EnumMember(Value = "Asia/Riyadh")]
        AsiaRiyadh,
        [EnumMember(Value = "Europe/Moscow")]
        EuropeMoscow,
        [EnumMember(Value = "Africa/Addis_Ababa")]
        AfricaAddisAbaba,
        [EnumMember(Value = "Africa/Nairobi")]
        AfricaNairobi,
        [EnumMember(Value = "Africa/Khartoum")]
        AfricaKhartoum,
        [EnumMember(Value = "Asia/Amman")]
        AsiaAmman,
        [EnumMember(Value = "Asia/Damascus")]
        AsiaDamascus,
        [EnumMember(Value = "Asia/Beirut")]
        AsiaBeirut,
        [EnumMember(Value = "Asia/Jerusalem")]
        AsiaJerusalem,
        [EnumMember(Value = "Europe/Istanbul")]
        EuropeIstanbul,
        [EnumMember(Value = "Europe/Kiev")]
        EuropeKiev,
        [EnumMember(Value = "Africa/Cairo")]
        AfricaCairo,
        [EnumMember(Value = "Europe/Sofia")]
        EuropeSofia,
        [EnumMember(Value = "Europe/Bucharest")]
        EuropeBucharest,
        [EnumMember(Value = "Europe/Athens")]
        EuropeAthens,
        [EnumMember(Value = "Africa/Lagos")]
        AfricaLagos,
        [EnumMember(Value = "Africa/Tripoli")]
        AfricaTripoli,
        [EnumMember(Value = "Africa/Tunis")]
        AfricaTunis,
        [EnumMember(Value = "Africa/Algiers")]
        AfricaAlgiers,
        [EnumMember(Value = "Europe/Helsinki")]
        EuropeHelsinki,
        [EnumMember(Value = "Europe/Oslo")]
        EuropeOslo,
        [EnumMember(Value = "Europe/Copenhagen")]
        EuropeCopenhagen,
        [EnumMember(Value = "Europe/Stockholm")]
        EuropeStockholm,
        [EnumMember(Value = "Europe/Budapest")]
        EuropeBudapest,
        [EnumMember(Value = "Europe/Warsaw")]
        EuropeWarsaw,
        [EnumMember(Value = "Europe/Prague")]
        EuropePrague,
        [EnumMember(Value = "Europe/Zurich")]
        EuropeZurich,
        [EnumMember(Value = "Europe/Vienna")]
        EuropeVienna,
        [EnumMember(Value = "Europe/Brussels")]
        EuropeBrussels,
        [EnumMember(Value = "Europe/Amsterdam")]
        EuropeAmsterdam,
        [EnumMember(Value = "Europe/Madrid")]
        EuropeMadrid,
        [EnumMember(Value = "Europe/Rome")]
        EuropeRome,
        [EnumMember(Value = "Europe/Berlin")]
        EuropeBerlin,
        [EnumMember(Value = "Europe/Paris")]
        EuropeParis,
        [EnumMember(Value = "Africa/Casablanca")]
        AfricaCasablanca,
        [EnumMember(Value = "Europe/Lisbon")]
        EuropeLisbon,
        [EnumMember(Value = "Europe/Dublin")]
        EuropeDublin,
        [EnumMember(Value = "Europe/London")]
        EuropeLondon,
        [EnumMember(Value = "Atlantic/Reykjavik")]
        AtlanticReykjavik,
        GMT,
        UTC,
        [EnumMember(Value = "Atlantic/Azores")]
        AtlanticAzores,
        [EnumMember(Value = "Atlantic/Cape_Verde")]
        AtlanticCapeVerde,
        [EnumMember(Value = "America/Buenos_Aires")]
        AmericaBuenosAires,
        [EnumMember(Value = "America/Sao_Paulo")]
        AmericaSaoPaulo,
        [EnumMember(Value = "America/St_Johns")]
        AmericaStJohns,
        [EnumMember(Value = "America/Caracas")]
        AmericaCaracas,
        [EnumMember(Value = "America/Halifax")]
        AmericaHalifax,
        [EnumMember(Value = "America/Lima")]
        AmericaLima,
        [EnumMember(Value = "America/Bogota")]
        AmericaBogota,
        [EnumMember(Value = "America/Cancun")]
        AmericaCancun,
        [EnumMember(Value = "America/Montreal")]
        AmericaMontreal,
        [EnumMember(Value = "America/Toronto")]
        AmericaToronto,
        [EnumMember(Value = "America/New_York")]
        AmericaNewYork,
        [EnumMember(Value = "America/Mexico_City")]
        AmericaMexicoCity,
        [EnumMember(Value = "America/Chicago")]
        AmericaChicago,
        [EnumMember(Value = "America/Phoenix")]
        AmericaPhoenix,
        [EnumMember(Value = "America/Denver")]
        AmericaDenver,
        [EnumMember(Value = "America/Vancouver")]
        AmericaVancouver,
        [EnumMember(Value = "America/Los_Angeles")]
        AmericaLosAngeles,
        [EnumMember(Value = "America/Anchorage")]
        AmericaAnchorage,
        [EnumMember(Value = "America/Honolulu")]
        AmericaHonolulu,
        [EnumMember(Value = "Pacific/Tahiti")]
        PacificTahiti,
        [EnumMember(Value = "Pacific/Marquesas")]
        PacificMarquesas,
        [EnumMember(Value = "Pacific/Guam")]
        PacificGuam,
        [EnumMember(Value = "Pacific/Port_Moresby")]
        PacificPortMoresby,
        [EnumMember(Value = "Pacific/Noumea")]
        PacificNoumea,
        [EnumMember(Value = "Africa/Johannesburg")]
        AfricaJohannesburg
    }

    public class ProjectDurationResponse
    {
        [JsonProperty("startDate")]
        public string StartDate { get; set; }

        [JsonProperty("endDate")]
        public string EndDate { get; set; }

        [JsonProperty("totalCalendarDays")]
        public int TotalCalendarDays { get; set; }

        [JsonProperty("totalBusinessDays")]
        public int TotalBusinessDays { get; set; }

        [JsonProperty("projectStatus")]
        public string ProjectStatus { get; set; }

        [JsonProperty("milestones")]
        public MilestoneAnalysis[] Milestones { get; set; }

        [JsonProperty("criticalPath")]
        public CriticalPath CriticalPath { get; set; }
    }

    public class MilestoneAnalysis
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("date")]
        public string Date { get; set; }

        [JsonProperty("daysFromStart")]
        public int DaysFromStart { get; set; }

        [JsonProperty("daysToEnd")]
        public int DaysToEnd { get; set; }

        [JsonProperty("percentComplete")]
        public double PercentComplete { get; set; }

        [JsonProperty("isOverdue")]
        public bool IsOverdue { get; set; }
    }

    public class CriticalPath
    {
        [JsonProperty("hasCriticalPath")]
        public bool HasCriticalPath { get; set; }

        [JsonProperty("criticalMilestones")]
        public string[] CriticalMilestones { get; set; }

        [JsonProperty("recommendedFocus")]
        public string RecommendedFocus { get; set; }
    }

    public class CalculateProjectDurationInput
    {
        [JsonProperty("startDate", DefaultValueHandling = DefaultValueHandling.Include)]
        public string StartDate { get; set; }

        [JsonProperty("endDate", DefaultValueHandling = DefaultValueHandling.Include)]
        public string EndDate { get; set; }

        [JsonProperty("projectStatus", DefaultValueHandling = DefaultValueHandling.Include)]
        public CalculateProjectDurationInputProjectStatusType? ProjectStatus { get; set; } = CalculateProjectDurationInputProjectStatusType.Active;

        [JsonProperty("milestones")]
        public Milestone[] Milestones { get; set; }

        [JsonProperty("holidays")]
        public Holiday[] Holidays { get; set; }

        [JsonProperty("includeWeekends", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? IncludeWeekends { get; set; } = false;

        [JsonProperty("outputFormat", DefaultValueHandling = DefaultValueHandling.Include)]
        public CalculateProjectDurationInputOutputFormatType? OutputFormat { get; set; } = CalculateProjectDurationInputOutputFormatType.Detailed;

        [JsonProperty("workingHoursPeriod", DefaultValueHandling = DefaultValueHandling.Include)]
        public CalculateProjectDurationInputWorkingHoursPeriodType? WorkingHoursPeriod { get; set; } = CalculateProjectDurationInputWorkingHoursPeriodType.Standard;
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum CalculateProjectDurationInputProjectStatusType
    {
        [EnumMember(Value = "planning")]
        Planning,
        [EnumMember(Value = "active")]
        Active,
        [EnumMember(Value = "on-hold")]
        OnHold,
        [EnumMember(Value = "completed")]
        Completed,
        [EnumMember(Value = "cancelled")]
        Cancelled,
        [EnumMember(Value = "delayed")]
        Delayed,
        [EnumMember(Value = "at-risk")]
        AtRisk,
        [EnumMember(Value = "pending-approval")]
        PendingApproval
    }

    public class Milestone
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("date")]
        public string Date { get; set; }
    }

    public class Holiday
    {
        [JsonProperty("date")]
        public string Date { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("type")]
        public HolidayTypeType Type { get; set; }

        [JsonProperty("observance")]
        public HolidayObservanceType Observance { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum HolidayTypeType
    {
        [EnumMember(Value = "federal")]
        Federal,
        [EnumMember(Value = "state")]
        State,
        [EnumMember(Value = "regional")]
        Regional,
        [EnumMember(Value = "religious")]
        Religious,
        [EnumMember(Value = "cultural")]
        Cultural,
        [EnumMember(Value = "company")]
        Company,
        [EnumMember(Value = "national")]
        National,
        [EnumMember(Value = "bank")]
        Bank,
        [EnumMember(Value = "school")]
        School,
        [EnumMember(Value = "custom")]
        Custom
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum HolidayObservanceType
    {
        [EnumMember(Value = "full-day")]
        FullDay,
        [EnumMember(Value = "half-day")]
        HalfDay,
        [EnumMember(Value = "optional")]
        Optional,
        [EnumMember(Value = "observed-if-weekend")]
        ObservedIfWeekend
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum CalculateProjectDurationInputOutputFormatType
    {
        [EnumMember(Value = "hours")]
        Hours,
        [EnumMember(Value = "days")]
        Days,
        [EnumMember(Value = "weeks")]
        Weeks,
        [EnumMember(Value = "months")]
        Months,
        [EnumMember(Value = "years")]
        Years,
        [EnumMember(Value = "detailed")]
        Detailed,
        [EnumMember(Value = "business-days")]
        BusinessDays,
        [EnumMember(Value = "calendar-days")]
        CalendarDays
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum CalculateProjectDurationInputWorkingHoursPeriodType
    {
        [EnumMember(Value = "standard")]
        Standard,
        [EnumMember(Value = "morning")]
        Morning,
        [EnumMember(Value = "evening")]
        Evening,
        [EnumMember(Value = "night")]
        Night,
        [EnumMember(Value = "flexible")]
        Flexible,
        [EnumMember(Value = "extended")]
        Extended,
        [EnumMember(Value = "shift-1")]
        Shift1,
        [EnumMember(Value = "shift-2")]
        Shift2,
        [EnumMember(Value = "shift-3")]
        Shift3
    }

    public class PayrollPeriodsResponse
    {
        [JsonProperty("periodType")]
        public string PeriodType { get; set; }

        [JsonProperty("totalPeriods")]
        public int TotalPeriods { get; set; }

        [JsonProperty("completePeriods")]
        public int CompletePeriods { get; set; }

        [JsonProperty("partialPeriods")]
        public int PartialPeriods { get; set; }

        [JsonProperty("periods")]
        public PayrollPeriod[] Periods { get; set; }
    }

    public class PayrollPeriod
    {
        [JsonProperty("periodNumber")]
        public int PeriodNumber { get; set; }

        [JsonProperty("startDate")]
        public string StartDate { get; set; }

        [JsonProperty("endDate")]
        public string EndDate { get; set; }

        [JsonProperty("workingDays")]
        public int WorkingDays { get; set; }

        [JsonProperty("isPartial")]
        public bool IsPartial { get; set; }
    }

    public class CalculatePayrollPeriodsInput
    {
        [JsonProperty("startDate", DefaultValueHandling = DefaultValueHandling.Include)]
        public string StartDate { get; set; }

        [JsonProperty("endDate")]
        public string EndDate { get; set; }

        [JsonProperty("periodType", DefaultValueHandling = DefaultValueHandling.Include)]
        public CalculatePayrollPeriodsInputPeriodTypeType PeriodType { get; set; }

        [JsonProperty("includePartialPeriods", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? IncludePartialPeriods { get; set; } = false;
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum CalculatePayrollPeriodsInputPeriodTypeType
    {
        [EnumMember(Value = "weekly")]
        Weekly,
        [EnumMember(Value = "bi-weekly")]
        BiWeekly,
        [EnumMember(Value = "semi-monthly")]
        SemiMonthly,
        [EnumMember(Value = "monthly")]
        Monthly
    }

    public class TimeZoneInfoResponse
    {
        [JsonProperty("timeZoneDetails")]
        public TimeZoneDetail[] TimeZoneDetails { get; set; }

        [JsonProperty("comparisons")]
        public TimeZoneComparison[] Comparisons { get; set; }
    }

    public class TimeZoneDetail
    {
        [JsonProperty("timeZoneId")]
        public string TimeZoneId { get; set; }

        [JsonProperty("displayName")]
        public string DisplayName { get; set; }

        [JsonProperty("currentOffset")]
        public string CurrentOffset { get; set; }

        [JsonProperty("standardOffset")]
        public string StandardOffset { get; set; }

        [JsonProperty("isDaylightSaving")]
        public bool IsDaylightSaving { get; set; }

        [JsonProperty("dstRules")]
        public DstRules DstRules { get; set; }

        [JsonProperty("regionalInfo")]
        public RegionalInfo RegionalInfo { get; set; }
    }

    public class DstRules
    {
        [JsonProperty("usesDst")]
        public bool UsesDst { get; set; }

        [JsonProperty("springForwardRule")]
        public string SpringForwardRule { get; set; }

        [JsonProperty("fallBackRule")]
        public string FallBackRule { get; set; }

        [JsonProperty("nextTransition")]
        public string NextTransition { get; set; }
    }

    public class RegionalInfo
    {
        [JsonProperty("countries")]
        public string[] Countries { get; set; }

        [JsonProperty("majorCities")]
        public string[] MajorCities { get; set; }

        [JsonProperty("politicalStatus")]
        public string PoliticalStatus { get; set; }
    }

    public class TimeZoneComparison
    {
        [JsonProperty("timeZone1")]
        public string TimeZone1 { get; set; }

        [JsonProperty("timeZone2")]
        public string TimeZone2 { get; set; }

        [JsonProperty("offsetDifference")]
        public string OffsetDifference { get; set; }

        [JsonProperty("sameSeasonalPattern")]
        public bool SameSeasonalPattern { get; set; }
    }

    public class GetTimeZoneInfoInput
    {
        [JsonProperty("timeZones", DefaultValueHandling = DefaultValueHandling.Include)]
        public TimeZoneEnum[] TimeZones { get; set; }

        [JsonProperty("referenceDate")]
        public string ReferenceDate { get; set; }

        [JsonProperty("includeHistory", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? IncludeHistory { get; set; } = false;
    }

    public class DeadlineCalculationResponse
    {
        [JsonProperty("deadlineDate")]
        public string DeadlineDate { get; set; }

        [JsonProperty("currentDate")]
        public string CurrentDate { get; set; }

        [JsonProperty("timeRemaining")]
        public DurationBreakdown TimeRemaining { get; set; }

        [JsonProperty("businessDaysRemaining")]
        public int BusinessDaysRemaining { get; set; }

        [JsonProperty("isPastDue")]
        public bool IsPastDue { get; set; }

        [JsonProperty("criticalStatus")]
        public DeadlineCalculationResponseCriticalStatusType CriticalStatus { get; set; }
    }

    public class DurationBreakdown
    {
        [JsonProperty("totalDays")]
        public int TotalDays { get; set; }

        [JsonProperty("totalHours")]
        public int TotalHours { get; set; }

        [JsonProperty("totalMinutes")]
        public int TotalMinutes { get; set; }

        [JsonProperty("totalSeconds")]
        public int TotalSeconds { get; set; }

        [JsonProperty("years")]
        public int Years { get; set; }

        [JsonProperty("months")]
        public int Months { get; set; }

        [JsonProperty("days")]
        public int Days { get; set; }

        [JsonProperty("hours")]
        public int Hours { get; set; }

        [JsonProperty("minutes")]
        public int Minutes { get; set; }

        [JsonProperty("seconds")]
        public int Seconds { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum DeadlineCalculationResponseCriticalStatusType
    {
        [EnumMember(Value = "on-track")]
        OnTrack,
        [EnumMember(Value = "approaching")]
        Approaching,
        [EnumMember(Value = "critical")]
        Critical,
        [EnumMember(Value = "overdue")]
        Overdue
    }

    public class DeadlineCalculationInput
    {
        [JsonProperty("deadlineDate", DefaultValueHandling = DefaultValueHandling.Include)]
        public string DeadlineDate { get; set; }

        [JsonProperty("currentDate")]
        public string CurrentDate { get; set; }

        [JsonProperty("includeWeekends", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? IncludeWeekends { get; set; } = true;

        [JsonProperty("holidays")]
        public string[] Holidays { get; set; }
    }

    public class CrossTzDurationResponse
    {
        [JsonProperty("startDateTimeUtc")]
        public string StartDateTimeUtc { get; set; }

        [JsonProperty("endDateTimeUtc")]
        public string EndDateTimeUtc { get; set; }

        [JsonProperty("duration")]
        public DurationBreakdown Duration { get; set; }

        [JsonProperty("dstTransitions")]
        public DstTransition[] DstTransitions { get; set; }

        [JsonProperty("timeZoneOffset")]
        public CrossTzDurationResponseTimeZoneOffsetType TimeZoneOffset { get; set; }
    }

    public class DstTransition
    {
        [JsonProperty("transitionDate")]
        public string TransitionDate { get; set; }

        [JsonProperty("timeZone")]
        public string TimeZone { get; set; }

        [JsonProperty("transitionType")]
        public DstTransitionTransitionTypeType TransitionType { get; set; }

        [JsonProperty("offsetBefore")]
        public string OffsetBefore { get; set; }

        [JsonProperty("offsetAfter")]
        public string OffsetAfter { get; set; }

        [JsonProperty("timeAdjustment")]
        public int TimeAdjustment { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum DstTransitionTransitionTypeType
    {
        [EnumMember(Value = "spring-forward")]
        SpringForward,
        [EnumMember(Value = "fall-back")]
        FallBack
    }

    public class CrossTzDurationResponseTimeZoneOffsetType
    {
        [JsonProperty("startOffset")]
        public string StartOffset { get; set; }

        [JsonProperty("endOffset")]
        public string EndOffset { get; set; }
    }

    public class CrossTzDurationInput
    {
        [JsonProperty("startDateTime", DefaultValueHandling = DefaultValueHandling.Include)]
        public string StartDateTime { get; set; }

        [JsonProperty("startTimeZone", DefaultValueHandling = DefaultValueHandling.Include)]
        public TimeZoneEnum StartTimeZone { get; set; }

        [JsonProperty("endDateTime", DefaultValueHandling = DefaultValueHandling.Include)]
        public string EndDateTime { get; set; }

        [JsonProperty("endTimeZone", DefaultValueHandling = DefaultValueHandling.Include)]
        public TimeZoneEnum EndTimeZone { get; set; }

        [JsonProperty("accountForDst", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? AccountForDst { get; set; } = true;
    }

    public class GlobalWorkingHoursResponse
    {
        [JsonProperty("totalWorkingHours")]
        public double TotalWorkingHours { get; set; }

        [JsonProperty("timeZoneResults")]
        public GlobalWorkingHoursResponseTimeZoneResultsTypeItem[] TimeZoneResults { get; set; }

        [JsonProperty("overlapHours")]
        public double OverlapHours { get; set; }
    }

    public class GlobalWorkingHoursResponseTimeZoneResultsTypeItem
    {
        [JsonProperty("timeZone")]
        public string TimeZone { get; set; }

        [JsonProperty("workingHours")]
        public double WorkingHours { get; set; }

        [JsonProperty("businessDays")]
        public int BusinessDays { get; set; }
    }

    public class CalculateGlobalWorkingHoursInput
    {
        [JsonProperty("startDateTime", DefaultValueHandling = DefaultValueHandling.Include)]
        public string StartDateTime { get; set; }

        [JsonProperty("endDateTime", DefaultValueHandling = DefaultValueHandling.Include)]
        public string EndDateTime { get; set; }

        [JsonProperty("timeZones", DefaultValueHandling = DefaultValueHandling.Include)]
        public TimeZoneEnum[] TimeZones { get; set; }

        [JsonProperty("workingHours")]
        public WorkingHours WorkingHours { get; set; }

        [JsonProperty("includeHolidays", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? IncludeHolidays { get; set; } = false;
    }

    public class WorkingHours
    {
        [JsonProperty("startTime")]
        public string StartTime { get; set; }

        [JsonProperty("endTime")]
        public string EndTime { get; set; }

        [JsonProperty("workingDays")]
        public WorkingHoursWorkingDaysTypeItem[] WorkingDays { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum WorkingHoursWorkingDaysTypeItem
    {
        [EnumMember(Value = "monday")]
        Monday,
        [EnumMember(Value = "tuesday")]
        Tuesday,
        [EnumMember(Value = "wednesday")]
        Wednesday,
        [EnumMember(Value = "thursday")]
        Thursday,
        [EnumMember(Value = "friday")]
        Friday,
        [EnumMember(Value = "saturday")]
        Saturday,
        [EnumMember(Value = "sunday")]
        Sunday
    }

    public class MeetingTimesResponse
    {
        [JsonProperty("optimalTimes")]
        public MeetingTimesResponseOptimalTimesTypeItem[] OptimalTimes { get; set; }

        [JsonProperty("timeZoneAnalysis")]
        public MeetingTimesResponseTimeZoneAnalysisType TimeZoneAnalysis { get; set; }
    }

    public class MeetingTimesResponseOptimalTimesTypeItem
    {
        [JsonProperty("startTime")]
        public string StartTime { get; set; }

        [JsonProperty("endTime")]
        public string EndTime { get; set; }

        [JsonProperty("suitabilityScore")]
        public double SuitabilityScore { get; set; }

        [JsonProperty("participantTimes")]
        public ParticipantLocalTime[] ParticipantTimes { get; set; }

        [JsonProperty("conflicts")]
        public MeetingTimesResponseOptimalTimesTypeItemConflictsTypeItem[] Conflicts { get; set; }
    }

    public class ParticipantLocalTime
    {
        [JsonProperty("participantName")]
        public string ParticipantName { get; set; }

        [JsonProperty("localDateTime")]
        public string LocalDateTime { get; set; }

        [JsonProperty("timeZone")]
        public TimeZoneEnum TimeZone { get; set; }

        [JsonProperty("isWithinWorkingHours")]
        public bool IsWithinWorkingHours { get; set; }

        [JsonProperty("conflictLevel")]
        public ParticipantLocalTimeConflictLevelType ConflictLevel { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum ParticipantLocalTimeConflictLevelType
    {
        [EnumMember(Value = "none")]
        None,
        [EnumMember(Value = "minor")]
        Minor,
        [EnumMember(Value = "moderate")]
        Moderate,
        [EnumMember(Value = "major")]
        Major
    }

    public class MeetingTimesResponseOptimalTimesTypeItemConflictsTypeItem
    {
        [JsonProperty("participantId")]
        public string ParticipantId { get; set; }

        [JsonProperty("conflictType")]
        public MeetingTimesResponseOptimalTimesTypeItemConflictsTypeItemConflictTypeType ConflictType { get; set; }

        [JsonProperty("severity")]
        public MeetingTimesResponseOptimalTimesTypeItemConflictsTypeItemSeverityType Severity { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum MeetingTimesResponseOptimalTimesTypeItemConflictsTypeItemConflictTypeType
    {
        [EnumMember(Value = "outside-working-hours")]
        OutsideWorkingHours,
        [EnumMember(Value = "holiday")]
        Holiday,
        [EnumMember(Value = "weekend")]
        Weekend,
        [EnumMember(Value = "unavailable")]
        Unavailable
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum MeetingTimesResponseOptimalTimesTypeItemConflictsTypeItemSeverityType
    {
        [EnumMember(Value = "minor")]
        Minor,
        [EnumMember(Value = "moderate")]
        Moderate,
        [EnumMember(Value = "major")]
        Major
    }

    public class MeetingTimesResponseTimeZoneAnalysisType
    {
        [JsonProperty("uniqueTimeZones")]
        public int UniqueTimeZones { get; set; }

        [JsonProperty("maxTimeOffset")]
        public double MaxTimeOffset { get; set; }
    }

    public class CalculateMeetingTimesInput
    {
        [JsonProperty("participants", DefaultValueHandling = DefaultValueHandling.Include)]
        public ParticipantLocalTime[] Participants { get; set; }

        [JsonProperty("durationMinutes", DefaultValueHandling = DefaultValueHandling.Include)]
        public int DurationMinutes { get; set; }

        [JsonProperty("meetingType", DefaultValueHandling = DefaultValueHandling.Include)]
        public CalculateMeetingTimesInputMeetingTypeType? MeetingType { get; set; } = CalculateMeetingTimesInputMeetingTypeType.TeamMeeting;

        [JsonProperty("priority", DefaultValueHandling = DefaultValueHandling.Include)]
        public CalculateMeetingTimesInputPriorityType? Priority { get; set; } = CalculateMeetingTimesInputPriorityType.Normal;

        [JsonProperty("dateRange")]
        public DateRange DateRange { get; set; }

        [JsonProperty("workingHours")]
        public WorkingHours WorkingHours { get; set; }

        [JsonProperty("preferredTimes")]
        public TimeSlot[] PreferredTimes { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum CalculateMeetingTimesInputMeetingTypeType
    {
        [EnumMember(Value = "stand-up")]
        StandUp,
        [EnumMember(Value = "one-on-one")]
        OneOnOne,
        [EnumMember(Value = "team-meeting")]
        TeamMeeting,
        [EnumMember(Value = "all-hands")]
        AllHands,
        [EnumMember(Value = "client-meeting")]
        ClientMeeting,
        [EnumMember(Value = "interview")]
        Interview,
        [EnumMember(Value = "training")]
        Training,
        [EnumMember(Value = "presentation")]
        Presentation,
        [EnumMember(Value = "workshop")]
        Workshop,
        [EnumMember(Value = "retrospective")]
        Retrospective,
        [EnumMember(Value = "planning")]
        Planning,
        [EnumMember(Value = "review")]
        Review
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum CalculateMeetingTimesInputPriorityType
    {
        [EnumMember(Value = "low")]
        Low,
        [EnumMember(Value = "normal")]
        Normal,
        [EnumMember(Value = "high")]
        High,
        [EnumMember(Value = "urgent")]
        Urgent,
        [EnumMember(Value = "critical")]
        Critical
    }

    public class DateRange
    {
        [JsonProperty("startDate")]
        public string StartDate { get; set; }

        [JsonProperty("endDate")]
        public string EndDate { get; set; }
    }

    public class TimeSlot
    {
        [JsonProperty("startTime")]
        public string StartTime { get; set; }

        [JsonProperty("endTime")]
        public string EndTime { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }
    }

    public class DstValidationResponse
    {
        [JsonProperty("validationResults")]
        public DstValidationResult[] ValidationResults { get; set; }

        [JsonProperty("overallCompliance")]
        public bool OverallCompliance { get; set; }

        [JsonProperty("complianceScore")]
        public double ComplianceScore { get; set; }

        [JsonProperty("recommendations")]
        public string[] Recommendations { get; set; }
    }

    public class DstValidationResult
    {
        [JsonProperty("calculationId")]
        public string CalculationId { get; set; }

        [JsonProperty("isValid")]
        public bool IsValid { get; set; }

        [JsonProperty("actualResult")]
        public DurationBreakdown ActualResult { get; set; }

        [JsonProperty("deviations")]
        public ValidationDeviation[] Deviations { get; set; }

        [JsonProperty("complianceIssues")]
        public string[] ComplianceIssues { get; set; }
    }

    public class ValidationDeviation
    {
        [JsonProperty("field")]
        public string Field { get; set; }

        [JsonProperty("expected")]
        public string Expected { get; set; }

        [JsonProperty("actual")]
        public string Actual { get; set; }

        [JsonProperty("severity")]
        public ValidationDeviationSeverityType Severity { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum ValidationDeviationSeverityType
    {
        [EnumMember(Value = "critical")]
        Critical,
        [EnumMember(Value = "major")]
        Major,
        [EnumMember(Value = "minor")]
        Minor,
        [EnumMember(Value = "warning")]
        Warning
    }

    public class ValidateDstCalculationsInput
    {
        [JsonProperty("calculations", DefaultValueHandling = DefaultValueHandling.Include)]
        public DstCalculation[] Calculations { get; set; }

        [JsonProperty("validationRules")]
        public ValidateDstCalculationsInputValidationRulesTypeItem[] ValidationRules { get; set; }

        [JsonProperty("complianceStandard", DefaultValueHandling = DefaultValueHandling.Include)]
        public ValidateDstCalculationsInputComplianceStandardType? ComplianceStandard { get; set; } = ValidateDstCalculationsInputComplianceStandardType.Iana;
    }

    public class DstCalculation
    {
        [JsonProperty("calculationId")]
        public string CalculationId { get; set; }

        [JsonProperty("timeZone")]
        public DstCalculationTimeZoneType TimeZone { get; set; }

        [JsonProperty("startDateTime")]
        public string StartDateTime { get; set; }

        [JsonProperty("endDateTime")]
        public string EndDateTime { get; set; }

        [JsonProperty("expectedResult")]
        public DurationBreakdown ExpectedResult { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum DstCalculationTimeZoneType
    {
        UTC,
        GMT,
        [EnumMember(Value = "America/New_York")]
        AmericaNewYork,
        [EnumMember(Value = "America/Chicago")]
        AmericaChicago,
        [EnumMember(Value = "America/Denver")]
        AmericaDenver,
        [EnumMember(Value = "America/Los_Angeles")]
        AmericaLosAngeles,
        [EnumMember(Value = "America/Phoenix")]
        AmericaPhoenix,
        [EnumMember(Value = "America/Anchorage")]
        AmericaAnchorage,
        [EnumMember(Value = "America/Honolulu")]
        AmericaHonolulu,
        [EnumMember(Value = "America/Toronto")]
        AmericaToronto,
        [EnumMember(Value = "America/Vancouver")]
        AmericaVancouver,
        [EnumMember(Value = "America/Montreal")]
        AmericaMontreal,
        [EnumMember(Value = "America/Halifax")]
        AmericaHalifax,
        [EnumMember(Value = "America/St_Johns")]
        AmericaStJohns,
        [EnumMember(Value = "America/Mexico_City")]
        AmericaMexicoCity,
        [EnumMember(Value = "America/Cancun")]
        AmericaCancun,
        [EnumMember(Value = "America/Sao_Paulo")]
        AmericaSaoPaulo,
        [EnumMember(Value = "America/Buenos_Aires")]
        AmericaBuenosAires,
        [EnumMember(Value = "America/Lima")]
        AmericaLima,
        [EnumMember(Value = "America/Bogota")]
        AmericaBogota,
        [EnumMember(Value = "America/Caracas")]
        AmericaCaracas,
        [EnumMember(Value = "Europe/London")]
        EuropeLondon,
        [EnumMember(Value = "Europe/Paris")]
        EuropeParis,
        [EnumMember(Value = "Europe/Berlin")]
        EuropeBerlin,
        [EnumMember(Value = "Europe/Rome")]
        EuropeRome,
        [EnumMember(Value = "Europe/Madrid")]
        EuropeMadrid,
        [EnumMember(Value = "Europe/Amsterdam")]
        EuropeAmsterdam,
        [EnumMember(Value = "Europe/Brussels")]
        EuropeBrussels,
        [EnumMember(Value = "Europe/Vienna")]
        EuropeVienna,
        [EnumMember(Value = "Europe/Zurich")]
        EuropeZurich,
        [EnumMember(Value = "Europe/Prague")]
        EuropePrague,
        [EnumMember(Value = "Europe/Warsaw")]
        EuropeWarsaw,
        [EnumMember(Value = "Europe/Budapest")]
        EuropeBudapest,
        [EnumMember(Value = "Europe/Stockholm")]
        EuropeStockholm,
        [EnumMember(Value = "Europe/Copenhagen")]
        EuropeCopenhagen,
        [EnumMember(Value = "Europe/Oslo")]
        EuropeOslo,
        [EnumMember(Value = "Europe/Helsinki")]
        EuropeHelsinki,
        [EnumMember(Value = "Europe/Dublin")]
        EuropeDublin,
        [EnumMember(Value = "Europe/Lisbon")]
        EuropeLisbon,
        [EnumMember(Value = "Europe/Athens")]
        EuropeAthens,
        [EnumMember(Value = "Europe/Istanbul")]
        EuropeIstanbul,
        [EnumMember(Value = "Europe/Moscow")]
        EuropeMoscow,
        [EnumMember(Value = "Europe/Kiev")]
        EuropeKiev,
        [EnumMember(Value = "Europe/Bucharest")]
        EuropeBucharest,
        [EnumMember(Value = "Europe/Sofia")]
        EuropeSofia,
        [EnumMember(Value = "Asia/Tokyo")]
        AsiaTokyo,
        [EnumMember(Value = "Asia/Shanghai")]
        AsiaShanghai,
        [EnumMember(Value = "Asia/Hong_Kong")]
        AsiaHongKong,
        [EnumMember(Value = "Asia/Singapore")]
        AsiaSingapore,
        [EnumMember(Value = "Asia/Bangkok")]
        AsiaBangkok,
        [EnumMember(Value = "Asia/Jakarta")]
        AsiaJakarta,
        [EnumMember(Value = "Asia/Manila")]
        AsiaManila,
        [EnumMember(Value = "Asia/Seoul")]
        AsiaSeoul,
        [EnumMember(Value = "Asia/Taipei")]
        AsiaTaipei,
        [EnumMember(Value = "Asia/Kuala_Lumpur")]
        AsiaKualaLumpur,
        [EnumMember(Value = "Asia/Ho_Chi_Minh")]
        AsiaHoChiMinh,
        [EnumMember(Value = "Asia/Phnom_Penh")]
        AsiaPhnomPenh,
        [EnumMember(Value = "Asia/Yangon")]
        AsiaYangon,
        [EnumMember(Value = "Asia/Dhaka")]
        AsiaDhaka,
        [EnumMember(Value = "Asia/Kolkata")]
        AsiaKolkata,
        [EnumMember(Value = "Asia/Karachi")]
        AsiaKarachi,
        [EnumMember(Value = "Asia/Dubai")]
        AsiaDubai,
        [EnumMember(Value = "Asia/Tehran")]
        AsiaTehran,
        [EnumMember(Value = "Asia/Baghdad")]
        AsiaBaghdad,
        [EnumMember(Value = "Asia/Riyadh")]
        AsiaRiyadh,
        [EnumMember(Value = "Asia/Kuwait")]
        AsiaKuwait,
        [EnumMember(Value = "Asia/Beirut")]
        AsiaBeirut,
        [EnumMember(Value = "Asia/Jerusalem")]
        AsiaJerusalem,
        [EnumMember(Value = "Asia/Amman")]
        AsiaAmman,
        [EnumMember(Value = "Asia/Damascus")]
        AsiaDamascus,
        [EnumMember(Value = "Asia/Tashkent")]
        AsiaTashkent,
        [EnumMember(Value = "Asia/Almaty")]
        AsiaAlmaty,
        [EnumMember(Value = "Asia/Novosibirsk")]
        AsiaNovosibirsk,
        [EnumMember(Value = "Asia/Krasnoyarsk")]
        AsiaKrasnoyarsk,
        [EnumMember(Value = "Asia/Irkutsk")]
        AsiaIrkutsk,
        [EnumMember(Value = "Asia/Vladivostok")]
        AsiaVladivostok,
        [EnumMember(Value = "Asia/Magadan")]
        AsiaMagadan,
        [EnumMember(Value = "Australia/Sydney")]
        AustraliaSydney,
        [EnumMember(Value = "Australia/Melbourne")]
        AustraliaMelbourne,
        [EnumMember(Value = "Australia/Brisbane")]
        AustraliaBrisbane,
        [EnumMember(Value = "Australia/Perth")]
        AustraliaPerth,
        [EnumMember(Value = "Australia/Adelaide")]
        AustraliaAdelaide,
        [EnumMember(Value = "Australia/Darwin")]
        AustraliaDarwin,
        [EnumMember(Value = "Australia/Hobart")]
        AustraliaHobart,
        [EnumMember(Value = "Pacific/Auckland")]
        PacificAuckland,
        [EnumMember(Value = "Pacific/Fiji")]
        PacificFiji,
        [EnumMember(Value = "Pacific/Honolulu")]
        PacificHonolulu,
        [EnumMember(Value = "Pacific/Guam")]
        PacificGuam,
        [EnumMember(Value = "Pacific/Port_Moresby")]
        PacificPortMoresby,
        [EnumMember(Value = "Pacific/Noumea")]
        PacificNoumea,
        [EnumMember(Value = "Pacific/Tahiti")]
        PacificTahiti,
        [EnumMember(Value = "Pacific/Marquesas")]
        PacificMarquesas,
        [EnumMember(Value = "Africa/Cairo")]
        AfricaCairo,
        [EnumMember(Value = "Africa/Lagos")]
        AfricaLagos,
        [EnumMember(Value = "Africa/Nairobi")]
        AfricaNairobi,
        [EnumMember(Value = "Africa/Johannesburg")]
        AfricaJohannesburg,
        [EnumMember(Value = "Africa/Casablanca")]
        AfricaCasablanca,
        [EnumMember(Value = "Africa/Algiers")]
        AfricaAlgiers,
        [EnumMember(Value = "Africa/Tunis")]
        AfricaTunis,
        [EnumMember(Value = "Africa/Tripoli")]
        AfricaTripoli,
        [EnumMember(Value = "Africa/Khartoum")]
        AfricaKhartoum,
        [EnumMember(Value = "Africa/Addis_Ababa")]
        AfricaAddisAbaba,
        [EnumMember(Value = "Atlantic/Reykjavik")]
        AtlanticReykjavik,
        [EnumMember(Value = "Atlantic/Azores")]
        AtlanticAzores,
        [EnumMember(Value = "Atlantic/Cape_Verde")]
        AtlanticCapeVerde,
        [EnumMember(Value = "Indian/Maldives")]
        IndianMaldives,
        [EnumMember(Value = "Indian/Mauritius")]
        IndianMauritius
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum ValidateDstCalculationsInputValidationRulesTypeItem
    {
        [EnumMember(Value = "standard_compliance")]
        StandardCompliance,
        [EnumMember(Value = "regional_accuracy")]
        RegionalAccuracy,
        [EnumMember(Value = "transition_logic")]
        TransitionLogic,
        [EnumMember(Value = "historical_consistency")]
        HistoricalConsistency
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum ValidateDstCalculationsInputComplianceStandardType
    {
        [EnumMember(Value = "iana")]
        Iana,
        [EnumMember(Value = "iso8601")]
        Iso8601,
        [EnumMember(Value = "rfc3339")]
        Rfc3339,
        [EnumMember(Value = "custom")]
        Custom
    }

    public class DstTransitionResponse
    {
        [JsonProperty("timeZone")]
        public DstTransitionResponseTimeZoneType TimeZone { get; set; }

        [JsonProperty("year")]
        public int Year { get; set; }

        [JsonProperty("transitions")]
        public DstTransition[] Transitions { get; set; }

        [JsonProperty("totalTransitions")]
        public int TotalTransitions { get; set; }

        [JsonProperty("impactAnalysis")]
        public DstImpactAnalysis ImpactAnalysis { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum DstTransitionResponseTimeZoneType
    {
        UTC,
        GMT,
        [EnumMember(Value = "America/New_York")]
        AmericaNewYork,
        [EnumMember(Value = "America/Chicago")]
        AmericaChicago,
        [EnumMember(Value = "America/Denver")]
        AmericaDenver,
        [EnumMember(Value = "America/Los_Angeles")]
        AmericaLosAngeles,
        [EnumMember(Value = "America/Phoenix")]
        AmericaPhoenix,
        [EnumMember(Value = "America/Anchorage")]
        AmericaAnchorage,
        [EnumMember(Value = "America/Honolulu")]
        AmericaHonolulu,
        [EnumMember(Value = "America/Toronto")]
        AmericaToronto,
        [EnumMember(Value = "America/Vancouver")]
        AmericaVancouver,
        [EnumMember(Value = "America/Montreal")]
        AmericaMontreal,
        [EnumMember(Value = "America/Halifax")]
        AmericaHalifax,
        [EnumMember(Value = "America/St_Johns")]
        AmericaStJohns,
        [EnumMember(Value = "America/Mexico_City")]
        AmericaMexicoCity,
        [EnumMember(Value = "America/Cancun")]
        AmericaCancun,
        [EnumMember(Value = "America/Sao_Paulo")]
        AmericaSaoPaulo,
        [EnumMember(Value = "America/Buenos_Aires")]
        AmericaBuenosAires,
        [EnumMember(Value = "America/Lima")]
        AmericaLima,
        [EnumMember(Value = "America/Bogota")]
        AmericaBogota,
        [EnumMember(Value = "America/Caracas")]
        AmericaCaracas,
        [EnumMember(Value = "Europe/London")]
        EuropeLondon,
        [EnumMember(Value = "Europe/Paris")]
        EuropeParis,
        [EnumMember(Value = "Europe/Berlin")]
        EuropeBerlin,
        [EnumMember(Value = "Europe/Rome")]
        EuropeRome,
        [EnumMember(Value = "Europe/Madrid")]
        EuropeMadrid,
        [EnumMember(Value = "Europe/Amsterdam")]
        EuropeAmsterdam,
        [EnumMember(Value = "Europe/Brussels")]
        EuropeBrussels,
        [EnumMember(Value = "Europe/Vienna")]
        EuropeVienna,
        [EnumMember(Value = "Europe/Zurich")]
        EuropeZurich,
        [EnumMember(Value = "Europe/Prague")]
        EuropePrague,
        [EnumMember(Value = "Europe/Warsaw")]
        EuropeWarsaw,
        [EnumMember(Value = "Europe/Budapest")]
        EuropeBudapest,
        [EnumMember(Value = "Europe/Stockholm")]
        EuropeStockholm,
        [EnumMember(Value = "Europe/Copenhagen")]
        EuropeCopenhagen,
        [EnumMember(Value = "Europe/Oslo")]
        EuropeOslo,
        [EnumMember(Value = "Europe/Helsinki")]
        EuropeHelsinki,
        [EnumMember(Value = "Europe/Dublin")]
        EuropeDublin,
        [EnumMember(Value = "Europe/Lisbon")]
        EuropeLisbon,
        [EnumMember(Value = "Europe/Athens")]
        EuropeAthens,
        [EnumMember(Value = "Europe/Istanbul")]
        EuropeIstanbul,
        [EnumMember(Value = "Europe/Moscow")]
        EuropeMoscow,
        [EnumMember(Value = "Europe/Kiev")]
        EuropeKiev,
        [EnumMember(Value = "Europe/Bucharest")]
        EuropeBucharest,
        [EnumMember(Value = "Europe/Sofia")]
        EuropeSofia,
        [EnumMember(Value = "Asia/Tokyo")]
        AsiaTokyo,
        [EnumMember(Value = "Asia/Shanghai")]
        AsiaShanghai,
        [EnumMember(Value = "Asia/Hong_Kong")]
        AsiaHongKong,
        [EnumMember(Value = "Asia/Singapore")]
        AsiaSingapore,
        [EnumMember(Value = "Asia/Bangkok")]
        AsiaBangkok,
        [EnumMember(Value = "Asia/Jakarta")]
        AsiaJakarta,
        [EnumMember(Value = "Asia/Manila")]
        AsiaManila,
        [EnumMember(Value = "Asia/Seoul")]
        AsiaSeoul,
        [EnumMember(Value = "Asia/Taipei")]
        AsiaTaipei,
        [EnumMember(Value = "Asia/Kuala_Lumpur")]
        AsiaKualaLumpur,
        [EnumMember(Value = "Asia/Ho_Chi_Minh")]
        AsiaHoChiMinh,
        [EnumMember(Value = "Asia/Phnom_Penh")]
        AsiaPhnomPenh,
        [EnumMember(Value = "Asia/Yangon")]
        AsiaYangon,
        [EnumMember(Value = "Asia/Dhaka")]
        AsiaDhaka,
        [EnumMember(Value = "Asia/Kolkata")]
        AsiaKolkata,
        [EnumMember(Value = "Asia/Karachi")]
        AsiaKarachi,
        [EnumMember(Value = "Asia/Dubai")]
        AsiaDubai,
        [EnumMember(Value = "Asia/Tehran")]
        AsiaTehran,
        [EnumMember(Value = "Asia/Baghdad")]
        AsiaBaghdad,
        [EnumMember(Value = "Asia/Riyadh")]
        AsiaRiyadh,
        [EnumMember(Value = "Asia/Kuwait")]
        AsiaKuwait,
        [EnumMember(Value = "Asia/Beirut")]
        AsiaBeirut,
        [EnumMember(Value = "Asia/Jerusalem")]
        AsiaJerusalem,
        [EnumMember(Value = "Asia/Amman")]
        AsiaAmman,
        [EnumMember(Value = "Asia/Damascus")]
        AsiaDamascus,
        [EnumMember(Value = "Asia/Tashkent")]
        AsiaTashkent,
        [EnumMember(Value = "Asia/Almaty")]
        AsiaAlmaty,
        [EnumMember(Value = "Asia/Novosibirsk")]
        AsiaNovosibirsk,
        [EnumMember(Value = "Asia/Krasnoyarsk")]
        AsiaKrasnoyarsk,
        [EnumMember(Value = "Asia/Irkutsk")]
        AsiaIrkutsk,
        [EnumMember(Value = "Asia/Vladivostok")]
        AsiaVladivostok,
        [EnumMember(Value = "Asia/Magadan")]
        AsiaMagadan,
        [EnumMember(Value = "Australia/Sydney")]
        AustraliaSydney,
        [EnumMember(Value = "Australia/Melbourne")]
        AustraliaMelbourne,
        [EnumMember(Value = "Australia/Brisbane")]
        AustraliaBrisbane,
        [EnumMember(Value = "Australia/Perth")]
        AustraliaPerth,
        [EnumMember(Value = "Australia/Adelaide")]
        AustraliaAdelaide,
        [EnumMember(Value = "Australia/Darwin")]
        AustraliaDarwin,
        [EnumMember(Value = "Australia/Hobart")]
        AustraliaHobart,
        [EnumMember(Value = "Pacific/Auckland")]
        PacificAuckland,
        [EnumMember(Value = "Pacific/Fiji")]
        PacificFiji,
        [EnumMember(Value = "Pacific/Honolulu")]
        PacificHonolulu,
        [EnumMember(Value = "Pacific/Guam")]
        PacificGuam,
        [EnumMember(Value = "Pacific/Port_Moresby")]
        PacificPortMoresby,
        [EnumMember(Value = "Pacific/Noumea")]
        PacificNoumea,
        [EnumMember(Value = "Pacific/Tahiti")]
        PacificTahiti,
        [EnumMember(Value = "Pacific/Marquesas")]
        PacificMarquesas,
        [EnumMember(Value = "Africa/Cairo")]
        AfricaCairo,
        [EnumMember(Value = "Africa/Lagos")]
        AfricaLagos,
        [EnumMember(Value = "Africa/Nairobi")]
        AfricaNairobi,
        [EnumMember(Value = "Africa/Johannesburg")]
        AfricaJohannesburg,
        [EnumMember(Value = "Africa/Casablanca")]
        AfricaCasablanca,
        [EnumMember(Value = "Africa/Algiers")]
        AfricaAlgiers,
        [EnumMember(Value = "Africa/Tunis")]
        AfricaTunis,
        [EnumMember(Value = "Africa/Tripoli")]
        AfricaTripoli,
        [EnumMember(Value = "Africa/Khartoum")]
        AfricaKhartoum,
        [EnumMember(Value = "Africa/Addis_Ababa")]
        AfricaAddisAbaba,
        [EnumMember(Value = "Atlantic/Reykjavik")]
        AtlanticReykjavik,
        [EnumMember(Value = "Atlantic/Azores")]
        AtlanticAzores,
        [EnumMember(Value = "Atlantic/Cape_Verde")]
        AtlanticCapeVerde,
        [EnumMember(Value = "Indian/Maldives")]
        IndianMaldives,
        [EnumMember(Value = "Indian/Mauritius")]
        IndianMauritius
    }

    public class DstImpactAnalysis
    {
        [JsonProperty("affectedHours")]
        public int AffectedHours { get; set; }

        [JsonProperty("businessImpact")]
        public DstImpactAnalysisBusinessImpactType BusinessImpact { get; set; }

        [JsonProperty("recommendations")]
        public string[] Recommendations { get; set; }

        [JsonProperty("criticalPeriods")]
        public CriticalPeriod[] CriticalPeriods { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum DstImpactAnalysisBusinessImpactType
    {
        [EnumMember(Value = "low")]
        Low,
        [EnumMember(Value = "medium")]
        Medium,
        [EnumMember(Value = "high")]
        High,
        [EnumMember(Value = "critical")]
        Critical
    }

    public class CriticalPeriod
    {
        [JsonProperty("startDateTime")]
        public string StartDateTime { get; set; }

        [JsonProperty("endDateTime")]
        public string EndDateTime { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("severity")]
        public CriticalPeriodSeverityType Severity { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum CriticalPeriodSeverityType
    {
        [EnumMember(Value = "low")]
        Low,
        [EnumMember(Value = "medium")]
        Medium,
        [EnumMember(Value = "high")]
        High,
        [EnumMember(Value = "critical")]
        Critical
    }

    public class CalculateDstTransitionInput
    {
        [JsonProperty("timeZone", DefaultValueHandling = DefaultValueHandling.Include)]
        public CalculateDstTransitionInputTimeZoneType TimeZone { get; set; }

        [JsonProperty("year", DefaultValueHandling = DefaultValueHandling.Include)]
        public int Year { get; set; }

        [JsonProperty("includeRules", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? IncludeRules { get; set; } = true;

        [JsonProperty("includeImpact", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? IncludeImpact { get; set; } = true;
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum CalculateDstTransitionInputTimeZoneType
    {
        UTC,
        GMT,
        [EnumMember(Value = "America/New_York")]
        AmericaNewYork,
        [EnumMember(Value = "America/Chicago")]
        AmericaChicago,
        [EnumMember(Value = "America/Denver")]
        AmericaDenver,
        [EnumMember(Value = "America/Los_Angeles")]
        AmericaLosAngeles,
        [EnumMember(Value = "America/Phoenix")]
        AmericaPhoenix,
        [EnumMember(Value = "America/Anchorage")]
        AmericaAnchorage,
        [EnumMember(Value = "America/Honolulu")]
        AmericaHonolulu,
        [EnumMember(Value = "America/Toronto")]
        AmericaToronto,
        [EnumMember(Value = "America/Vancouver")]
        AmericaVancouver,
        [EnumMember(Value = "America/Montreal")]
        AmericaMontreal,
        [EnumMember(Value = "America/Halifax")]
        AmericaHalifax,
        [EnumMember(Value = "America/St_Johns")]
        AmericaStJohns,
        [EnumMember(Value = "America/Mexico_City")]
        AmericaMexicoCity,
        [EnumMember(Value = "America/Cancun")]
        AmericaCancun,
        [EnumMember(Value = "America/Sao_Paulo")]
        AmericaSaoPaulo,
        [EnumMember(Value = "America/Buenos_Aires")]
        AmericaBuenosAires,
        [EnumMember(Value = "America/Lima")]
        AmericaLima,
        [EnumMember(Value = "America/Bogota")]
        AmericaBogota,
        [EnumMember(Value = "America/Caracas")]
        AmericaCaracas,
        [EnumMember(Value = "Europe/London")]
        EuropeLondon,
        [EnumMember(Value = "Europe/Paris")]
        EuropeParis,
        [EnumMember(Value = "Europe/Berlin")]
        EuropeBerlin,
        [EnumMember(Value = "Europe/Rome")]
        EuropeRome,
        [EnumMember(Value = "Europe/Madrid")]
        EuropeMadrid,
        [EnumMember(Value = "Europe/Amsterdam")]
        EuropeAmsterdam,
        [EnumMember(Value = "Europe/Brussels")]
        EuropeBrussels,
        [EnumMember(Value = "Europe/Vienna")]
        EuropeVienna,
        [EnumMember(Value = "Europe/Zurich")]
        EuropeZurich,
        [EnumMember(Value = "Europe/Prague")]
        EuropePrague,
        [EnumMember(Value = "Europe/Warsaw")]
        EuropeWarsaw,
        [EnumMember(Value = "Europe/Budapest")]
        EuropeBudapest,
        [EnumMember(Value = "Europe/Stockholm")]
        EuropeStockholm,
        [EnumMember(Value = "Europe/Copenhagen")]
        EuropeCopenhagen,
        [EnumMember(Value = "Europe/Oslo")]
        EuropeOslo,
        [EnumMember(Value = "Europe/Helsinki")]
        EuropeHelsinki,
        [EnumMember(Value = "Europe/Dublin")]
        EuropeDublin,
        [EnumMember(Value = "Europe/Lisbon")]
        EuropeLisbon,
        [EnumMember(Value = "Europe/Athens")]
        EuropeAthens,
        [EnumMember(Value = "Europe/Istanbul")]
        EuropeIstanbul,
        [EnumMember(Value = "Europe/Moscow")]
        EuropeMoscow,
        [EnumMember(Value = "Europe/Kiev")]
        EuropeKiev,
        [EnumMember(Value = "Europe/Bucharest")]
        EuropeBucharest,
        [EnumMember(Value = "Europe/Sofia")]
        EuropeSofia,
        [EnumMember(Value = "Asia/Tokyo")]
        AsiaTokyo,
        [EnumMember(Value = "Asia/Shanghai")]
        AsiaShanghai,
        [EnumMember(Value = "Asia/Hong_Kong")]
        AsiaHongKong,
        [EnumMember(Value = "Asia/Singapore")]
        AsiaSingapore,
        [EnumMember(Value = "Asia/Bangkok")]
        AsiaBangkok,
        [EnumMember(Value = "Asia/Jakarta")]
        AsiaJakarta,
        [EnumMember(Value = "Asia/Manila")]
        AsiaManila,
        [EnumMember(Value = "Asia/Seoul")]
        AsiaSeoul,
        [EnumMember(Value = "Asia/Taipei")]
        AsiaTaipei,
        [EnumMember(Value = "Asia/Kuala_Lumpur")]
        AsiaKualaLumpur,
        [EnumMember(Value = "Asia/Ho_Chi_Minh")]
        AsiaHoChiMinh,
        [EnumMember(Value = "Asia/Phnom_Penh")]
        AsiaPhnomPenh,
        [EnumMember(Value = "Asia/Yangon")]
        AsiaYangon,
        [EnumMember(Value = "Asia/Dhaka")]
        AsiaDhaka,
        [EnumMember(Value = "Asia/Kolkata")]
        AsiaKolkata,
        [EnumMember(Value = "Asia/Karachi")]
        AsiaKarachi,
        [EnumMember(Value = "Asia/Dubai")]
        AsiaDubai,
        [EnumMember(Value = "Asia/Tehran")]
        AsiaTehran,
        [EnumMember(Value = "Asia/Baghdad")]
        AsiaBaghdad,
        [EnumMember(Value = "Asia/Riyadh")]
        AsiaRiyadh,
        [EnumMember(Value = "Asia/Kuwait")]
        AsiaKuwait,
        [EnumMember(Value = "Asia/Beirut")]
        AsiaBeirut,
        [EnumMember(Value = "Asia/Jerusalem")]
        AsiaJerusalem,
        [EnumMember(Value = "Asia/Amman")]
        AsiaAmman,
        [EnumMember(Value = "Asia/Damascus")]
        AsiaDamascus,
        [EnumMember(Value = "Asia/Tashkent")]
        AsiaTashkent,
        [EnumMember(Value = "Asia/Almaty")]
        AsiaAlmaty,
        [EnumMember(Value = "Asia/Novosibirsk")]
        AsiaNovosibirsk,
        [EnumMember(Value = "Asia/Krasnoyarsk")]
        AsiaKrasnoyarsk,
        [EnumMember(Value = "Asia/Irkutsk")]
        AsiaIrkutsk,
        [EnumMember(Value = "Asia/Vladivostok")]
        AsiaVladivostok,
        [EnumMember(Value = "Asia/Magadan")]
        AsiaMagadan,
        [EnumMember(Value = "Australia/Sydney")]
        AustraliaSydney,
        [EnumMember(Value = "Australia/Melbourne")]
        AustraliaMelbourne,
        [EnumMember(Value = "Australia/Brisbane")]
        AustraliaBrisbane,
        [EnumMember(Value = "Australia/Perth")]
        AustraliaPerth,
        [EnumMember(Value = "Australia/Adelaide")]
        AustraliaAdelaide,
        [EnumMember(Value = "Australia/Darwin")]
        AustraliaDarwin,
        [EnumMember(Value = "Australia/Hobart")]
        AustraliaHobart,
        [EnumMember(Value = "Pacific/Auckland")]
        PacificAuckland,
        [EnumMember(Value = "Pacific/Fiji")]
        PacificFiji,
        [EnumMember(Value = "Pacific/Honolulu")]
        PacificHonolulu,
        [EnumMember(Value = "Pacific/Guam")]
        PacificGuam,
        [EnumMember(Value = "Pacific/Port_Moresby")]
        PacificPortMoresby,
        [EnumMember(Value = "Pacific/Noumea")]
        PacificNoumea,
        [EnumMember(Value = "Pacific/Tahiti")]
        PacificTahiti,
        [EnumMember(Value = "Pacific/Marquesas")]
        PacificMarquesas,
        [EnumMember(Value = "Africa/Cairo")]
        AfricaCairo,
        [EnumMember(Value = "Africa/Lagos")]
        AfricaLagos,
        [EnumMember(Value = "Africa/Nairobi")]
        AfricaNairobi,
        [EnumMember(Value = "Africa/Johannesburg")]
        AfricaJohannesburg,
        [EnumMember(Value = "Africa/Casablanca")]
        AfricaCasablanca,
        [EnumMember(Value = "Africa/Algiers")]
        AfricaAlgiers,
        [EnumMember(Value = "Africa/Tunis")]
        AfricaTunis,
        [EnumMember(Value = "Africa/Tripoli")]
        AfricaTripoli,
        [EnumMember(Value = "Africa/Khartoum")]
        AfricaKhartoum,
        [EnumMember(Value = "Africa/Addis_Ababa")]
        AfricaAddisAbaba,
        [EnumMember(Value = "Atlantic/Reykjavik")]
        AtlanticReykjavik,
        [EnumMember(Value = "Atlantic/Azores")]
        AtlanticAzores,
        [EnumMember(Value = "Atlantic/Cape_Verde")]
        AtlanticCapeVerde,
        [EnumMember(Value = "Indian/Maldives")]
        IndianMaldives,
        [EnumMember(Value = "Indian/Mauritius")]
        IndianMauritius
    }

    public class DstHistoryResponse
    {
        [JsonProperty("timeZoneHistories")]
        public TimeZoneHistory[] TimeZoneHistories { get; set; }

        [JsonProperty("summary")]
        public DstHistorySummary Summary { get; set; }
    }

    public class TimeZoneHistory
    {
        [JsonProperty("timeZone")]
        public string TimeZone { get; set; }

        [JsonProperty("historicalTransitions")]
        public HistoricalDstTransition[] HistoricalTransitions { get; set; }

        [JsonProperty("totalTransitions")]
        public int TotalTransitions { get; set; }

        [JsonProperty("policyChanges")]
        public DstPolicyChange[] PolicyChanges { get; set; }
    }

    public class HistoricalDstTransition
    {
        [JsonProperty("year")]
        public int Year { get; set; }

        [JsonProperty("transitionType")]
        public HistoricalDstTransitionTransitionTypeType TransitionType { get; set; }

        [JsonProperty("transitionDate")]
        public string TransitionDate { get; set; }

        [JsonProperty("offsetChange")]
        public string OffsetChange { get; set; }

        [JsonProperty("ruleApplied")]
        public string RuleApplied { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum HistoricalDstTransitionTransitionTypeType
    {
        [EnumMember(Value = "spring_forward")]
        SpringForward,
        [EnumMember(Value = "fall_back")]
        FallBack
    }

    public class DstPolicyChange
    {
        [JsonProperty("effectiveDate")]
        public string EffectiveDate { get; set; }

        [JsonProperty("changeDescription")]
        public string ChangeDescription { get; set; }

        [JsonProperty("reason")]
        public string Reason { get; set; }

        [JsonProperty("impact")]
        public DstPolicyChangeImpactType Impact { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum DstPolicyChangeImpactType
    {
        [EnumMember(Value = "minor")]
        Minor,
        [EnumMember(Value = "moderate")]
        Moderate,
        [EnumMember(Value = "major")]
        Major,
        [EnumMember(Value = "significant")]
        Significant
    }

    public class DstHistorySummary
    {
        [JsonProperty("totalTimeZones")]
        public int TotalTimeZones { get; set; }

        [JsonProperty("totalTransitions")]
        public int TotalTransitions { get; set; }

        [JsonProperty("mostActiveTimeZone")]
        public string MostActiveTimeZone { get; set; }

        [JsonProperty("trends")]
        public string[] Trends { get; set; }

        [JsonProperty("globalPatterns")]
        public string[] GlobalPatterns { get; set; }
    }

    public class GetDstHistoryInput
    {
        [JsonProperty("timeZones", DefaultValueHandling = DefaultValueHandling.Include)]
        public TimeZoneEnum[] TimeZones { get; set; }

        [JsonProperty("startYear", DefaultValueHandling = DefaultValueHandling.Include)]
        public int? StartYear { get; set; } = 2000;

        [JsonProperty("endYear")]
        public int? EndYear { get; set; }

        [JsonProperty("includePoliticalChanges", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? IncludePoliticalChanges { get; set; } = true;
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Durationcalculator;

    public partial class WorkflowManagedActions
    {
        public DurationcalculatorActions Durationcalculator(string connectionId) => new DurationcalculatorActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public DurationcalculatorTriggers Durationcalculator(string connectionId) => new DurationcalculatorTriggers(connectionId);
    }
}