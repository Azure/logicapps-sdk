//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Worldwideholidaysip
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class WorldwideholidaysipActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "worldwideholidaysip")]
        public IBodyWorkflowAction<CountryInfoDto> CountryCountryInfo(Expression<Func<string>> countryCode)
        {
            var apiCallPath = String.Format("/api/v3/CountryInfo/{0}", ExpressionConverter.ConvertWithUrlEncoding(countryCode, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<CountryInfoDto>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "worldwideholidaysip")]
        public IBodyWorkflowAction<CountryV3Dto[]> CountryAvailableCountries()
        {
            var apiCallPath = "/api/v3/AvailableCountries";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<CountryV3Dto[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "worldwideholidaysip")]
        public IBodyWorkflowAction<LongWeekendV3Dto[]> LongWeekendLongWeekend(Expression<Func<int>> year, Expression<Func<string>> countryCode)
        {
            var apiCallPath = String.Format("/api/v3/LongWeekend/{0}/{1}", ExpressionConverter.ConvertWithUrlEncoding(year, 1), ExpressionConverter.ConvertWithUrlEncoding(countryCode, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<LongWeekendV3Dto[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "worldwideholidaysip")]
        public IBodyWorkflowAction<PublicHolidayV3Dto[]> GetPublicHolidays(Expression<Func<int>> year, Expression<Func<string>> countryCode)
        {
            var apiCallPath = String.Format("/api/v3/PublicHolidays/{0}/{1}", ExpressionConverter.ConvertWithUrlEncoding(year, 1), ExpressionConverter.ConvertWithUrlEncoding(countryCode, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<PublicHolidayV3Dto[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "worldwideholidaysip")]
        public IWorkflowAction IsTodayPublicHoliday(Expression<Func<string>> countryCode, Expression<Func<string>> countyCode = null, Expression<Func<int>> offset = null)
        {
            var apiCallPath = String.Format("/api/v3/IsTodayPublicHoliday/{0}", ExpressionConverter.ConvertWithUrlEncoding(countryCode, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (countyCode != null)
                callPayload.Queries["countyCode"] = ExpressionConverter.Convert(countyCode);
            callPayload.Queries["offset"] = Convert.ToString(0);
            if (offset != null)
                callPayload.Queries["offset"] = ExpressionConverter.Convert(offset);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "worldwideholidaysip")]
        public IBodyWorkflowAction<PublicHolidayV3Dto[]> NextPublicHolidays(Expression<Func<string>> countryCode)
        {
            var apiCallPath = String.Format("/api/v3/NextPublicHolidays/{0}", ExpressionConverter.ConvertWithUrlEncoding(countryCode, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<PublicHolidayV3Dto[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "worldwideholidaysip")]
        public IBodyWorkflowAction<PublicHolidayV3Dto[]> NextPublicHolidaysWorldwide()
        {
            var apiCallPath = "/api/v3/NextPublicHolidaysWorldwide";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<PublicHolidayV3Dto[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "worldwideholidaysip")]
        public IBodyWorkflowAction<VersionInfoDto> GetVersion()
        {
            var apiCallPath = "/api/v3/Version";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<VersionInfoDto>(callPayload);
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