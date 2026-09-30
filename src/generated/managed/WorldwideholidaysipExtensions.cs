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
        public IBodyWorkflowAction<CountryInfoDto> CountryCountryInfo([WorkflowExpression] Func<string> countryCode)
        {
            SourceExpression.Validate(countryCode, nameof(countryCode), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/v3/CountryInfo/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(countryCode, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<CountryInfoDto>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "worldwideholidaysip")]
        public IBodyWorkflowAction<CountryV3Dto[]> CountryAvailableCountries()
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api/v3/AvailableCountries";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<CountryV3Dto[]>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "worldwideholidaysip")]
        public IBodyWorkflowAction<LongWeekendV3Dto[]> LongWeekendLongWeekend([WorkflowExpression] Func<int> year, [WorkflowExpression] Func<string> countryCode)
        {
            SourceExpression.Validate(year, nameof(year), required: true);
            SourceExpression.Validate(countryCode, nameof(countryCode), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/v3/LongWeekend/{0}/{1}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncodingWithInt(year, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(countryCode, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<LongWeekendV3Dto[]>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "worldwideholidaysip")]
        public IBodyWorkflowAction<PublicHolidayV3Dto[]> GetPublicHolidays([WorkflowExpression] Func<int> year, [WorkflowExpression] Func<string> countryCode)
        {
            SourceExpression.Validate(year, nameof(year), required: true);
            SourceExpression.Validate(countryCode, nameof(countryCode), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/v3/PublicHolidays/{0}/{1}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncodingWithInt(year, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(countryCode, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<PublicHolidayV3Dto[]>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "worldwideholidaysip")]
        public IWorkflowAction IsTodayPublicHoliday([WorkflowExpression] Func<string> countryCode, [WorkflowExpression] Func<string> countyCode = null, [WorkflowExpression] Func<int> offset = null)
        {
            SourceExpression.Validate(countryCode, nameof(countryCode), required: true);
            SourceExpression.Validate(countyCode, nameof(countyCode), required: false);
            SourceExpression.Validate(offset, nameof(offset), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/v3/IsTodayPublicHoliday/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(countryCode, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (countyCode != null)
                    callPayload.Queries["countyCode"] = SourceExpressionConverter.ConvertO(countyCode);
                callPayload.Queries["offset"] = Convert.ToString(0);
                if (offset != null)
                    callPayload.Queries["offset"] = SourceExpressionConverter.ConvertO(offset);
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "worldwideholidaysip")]
        public IBodyWorkflowAction<PublicHolidayV3Dto[]> NextPublicHolidays([WorkflowExpression] Func<string> countryCode)
        {
            SourceExpression.Validate(countryCode, nameof(countryCode), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/v3/NextPublicHolidays/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(countryCode, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<PublicHolidayV3Dto[]>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "worldwideholidaysip")]
        public IBodyWorkflowAction<PublicHolidayV3Dto[]> NextPublicHolidaysWorldwide()
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api/v3/NextPublicHolidaysWorldwide";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<PublicHolidayV3Dto[]>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "worldwideholidaysip")]
        public IBodyWorkflowAction<VersionInfoDto> GetVersion()
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api/v3/Version";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<VersionInfoDto>(BuildSourceInput);
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