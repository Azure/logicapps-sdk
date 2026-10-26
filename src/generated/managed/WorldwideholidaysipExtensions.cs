//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Worldwideholidaysip
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class WorldwideholidaysipActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "worldwideholidaysip")]
        public IBodyWorkflowAction<CountryInfoDto, ApiConnectionActionConfiguration> CountryCountryInfo(Expression<Func<string>> countryCode)
        {
            var __workflow_countryCode = WorkflowExpression.Compile(countryCode, nameof(countryCode), required: true);
            return new DeferredBodyAction<CountryInfoDto, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/v3/CountryInfo/{0}", __workflow_countryCode.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<CountryInfoDto>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "worldwideholidaysip")]
        public IBodyWorkflowAction<CountryV3Dto[], ApiConnectionActionConfiguration> CountryAvailableCountries()
        {
            return new DeferredBodyAction<CountryV3Dto[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/v3/AvailableCountries";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<CountryV3Dto[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "worldwideholidaysip")]
        public IBodyWorkflowAction<LongWeekendV3Dto[], ApiConnectionActionConfiguration> LongWeekendLongWeekend(Expression<Func<int>> year, Expression<Func<string>> countryCode)
        {
            var __workflow_year = WorkflowExpression.Compile(year, nameof(year), required: true);
            var __workflow_countryCode = WorkflowExpression.Compile(countryCode, nameof(countryCode), required: true);
            return new DeferredBodyAction<LongWeekendV3Dto[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/v3/LongWeekend/{0}/{1}", __workflow_year.WithUrlEncoding(1), __workflow_countryCode.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<LongWeekendV3Dto[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "worldwideholidaysip")]
        public IBodyWorkflowAction<PublicHolidayV3Dto[], ApiConnectionActionConfiguration> GetPublicHolidays(Expression<Func<int>> year, Expression<Func<string>> countryCode)
        {
            var __workflow_year = WorkflowExpression.Compile(year, nameof(year), required: true);
            var __workflow_countryCode = WorkflowExpression.Compile(countryCode, nameof(countryCode), required: true);
            return new DeferredBodyAction<PublicHolidayV3Dto[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/v3/PublicHolidays/{0}/{1}", __workflow_year.WithUrlEncoding(1), __workflow_countryCode.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<PublicHolidayV3Dto[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "worldwideholidaysip")]
        public IWorkflowAction<ApiConnectionActionConfiguration> IsTodayPublicHoliday(Expression<Func<string>> countryCode, Expression<Func<string>> countyCode = null, Expression<Func<int>> offset = null)
        {
            var __workflow_countryCode = WorkflowExpression.Compile(countryCode, nameof(countryCode), required: true);
            var __workflow_countyCode = WorkflowExpression.Compile(countyCode, nameof(countyCode), required: false);
            var __workflow_offset = WorkflowExpression.Compile(offset, nameof(offset), required: false);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/v3/IsTodayPublicHoliday/{0}", __workflow_countryCode.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_countyCode != null)
                    callPayload.Queries["countyCode"] = ExpressionConverter.Convert(__workflow_countyCode);
                callPayload.Queries["offset"] = Convert.ToString(0);
                if (__workflow_offset != null)
                    callPayload.Queries["offset"] = ExpressionConverter.Convert(__workflow_offset);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "worldwideholidaysip")]
        public IBodyWorkflowAction<PublicHolidayV3Dto[], ApiConnectionActionConfiguration> NextPublicHolidays(Expression<Func<string>> countryCode)
        {
            var __workflow_countryCode = WorkflowExpression.Compile(countryCode, nameof(countryCode), required: true);
            return new DeferredBodyAction<PublicHolidayV3Dto[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/v3/NextPublicHolidays/{0}", __workflow_countryCode.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<PublicHolidayV3Dto[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "worldwideholidaysip")]
        public IBodyWorkflowAction<PublicHolidayV3Dto[], ApiConnectionActionConfiguration> NextPublicHolidaysWorldwide()
        {
            return new DeferredBodyAction<PublicHolidayV3Dto[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/v3/NextPublicHolidaysWorldwide";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<PublicHolidayV3Dto[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "worldwideholidaysip")]
        public IBodyWorkflowAction<VersionInfoDto, ApiConnectionActionConfiguration> GetVersion()
        {
            return new DeferredBodyAction<VersionInfoDto, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/v3/Version";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<VersionInfoDto>(callPayload);
            });
        }
    }

    public class WorldwideholidaysipTriggers([ConnectionName] string connectionId)
    {
    }

    public class CountryInfoDto
    {
        [JsonProperty("commonName")]
        public string CommonName { get; set; }

        [JsonProperty("officialName")]
        public string OfficialName { get; set; }

        [JsonProperty("countryCode")]
        public string CountryCode { get; set; }

        [JsonProperty("region")]
        public string Region { get; set; }

        [JsonProperty("borders")]
        public CountryInfoDto[] Borders { get; set; }
    }

    public class CountryV3Dto
    {
        [JsonProperty("countryCode")]
        public string CountryCode { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class LongWeekendV3Dto
    {
        [JsonProperty("startDate")]
        public string StartDate { get; set; }

        [JsonProperty("endDate")]
        public string EndDate { get; set; }

        [JsonProperty("dayCount")]
        public int DayCount { get; set; }

        [JsonProperty("needBridgeDay")]
        public bool NeedBridgeDay { get; set; }
    }

    public class PublicHolidayV3Dto
    {
        [JsonProperty("date")]
        public string Date { get; set; }

        [JsonProperty("localName")]
        public string LocalName { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("countryCode")]
        public string CountryCode { get; set; }

        [JsonProperty("fixed")]
        public bool Fixed { get; set; }

        [JsonProperty("global")]
        public bool Global { get; set; }

        [JsonProperty("counties")]
        public string[] Counties { get; set; }

        [JsonProperty("launchYear")]
        public int LaunchYear { get; set; }

        [JsonProperty("types")]
        public PublicHolidayType[] Types { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum PublicHolidayType
    {
        Public,
        Bank,
        School,
        Authorities,
        Optional,
        Observance
    }

    public class VersionInfoDto
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("version")]
        public string Version { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Worldwideholidaysip;

    public partial class WorkflowManagedActions
    {
        public WorldwideholidaysipActions Worldwideholidaysip(string connectionId) => new WorldwideholidaysipActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public WorldwideholidaysipTriggers Worldwideholidaysip(string connectionId) => new WorldwideholidaysipTriggers(connectionId);
    }
}