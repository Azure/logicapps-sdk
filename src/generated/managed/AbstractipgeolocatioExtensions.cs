//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Abstractipgeolocatio
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class AbstractipgeolocatioActions([ConnectionName] string connectionId)
    {

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "abstractipgeolocatio")]
        [WorkflowExpressionFactory(nameof(__BuildAnalyze))]
        public IBodyWorkflowAction<AnalyzeResponse> Analyze([WorkflowExpression] Func<string> ipAddress, [WorkflowExpression] Func<string> fields = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<AnalyzeResponse> __BuildAnalyze(WorkflowExpression<string> ipAddress, WorkflowExpression<string> fields = null)
        {
            WorkflowExpression.Validate(ipAddress, nameof(ipAddress), required: true);
            WorkflowExpression.Validate(fields, nameof(fields), required: false);
            return new DeferredBodyAction<AnalyzeResponse>(() =>
            {
                var apiCallPath = "/v1/";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["ip_address"] = ExpressionConverter.Convert(ipAddress);
                if (fields != null)
                    callPayload.Queries["fields"] = ExpressionConverter.Convert(fields);
                return new ApiConnectionAction<AnalyzeResponse>(callPayload);
            });
        }
    }

    public class AbstractipgeolocatioTriggers([ConnectionName] string connectionId)
    {
    }

    public class AnalyzeResponse
    {
        [JsonProperty("ip_address")]
        public string IpAddress { get; set; }

        [JsonProperty("city")]
        public string City { get; set; }

        [JsonProperty("city_geoname_id")]
        public int CityGeonameId { get; set; }

        [JsonProperty("region")]
        public string Region { get; set; }

        [JsonProperty("region_iso_code")]
        public string RegionIsoCode { get; set; }

        [JsonProperty("region_geoname_id")]
        public int RegionGeonameId { get; set; }

        [JsonProperty("postal_code")]
        public string PostalCode { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("country_code")]
        public string CountryCode { get; set; }

        [JsonProperty("country_geoname_id")]
        public int CountryGeonameId { get; set; }

        [JsonProperty("country_is_eu")]
        public bool CountryIsEu { get; set; }

        [JsonProperty("continent")]
        public string Continent { get; set; }

        [JsonProperty("continent_code")]
        public string ContinentCode { get; set; }

        [JsonProperty("continent_geoname_id")]
        public int ContinentGeonameId { get; set; }

        [JsonProperty("longitude")]
        public double Longitude { get; set; }

        [JsonProperty("latitude")]
        public double Latitude { get; set; }

        [JsonProperty("security")]
        public AnalyzeResponseSecurityType Security { get; set; }

        [JsonProperty("timezone")]
        public AnalyzeResponseTimezoneType Timezone { get; set; }

        [JsonProperty("flag")]
        public AnalyzeResponseFlagType Flag { get; set; }

        [JsonProperty("currency")]
        public AnalyzeResponseCurrencyType Currency { get; set; }

        [JsonProperty("connection")]
        public AnalyzeResponseConnectionType Connection { get; set; }
    }

    public class AnalyzeResponseSecurityType
    {
        [JsonProperty("is_vpn")]
        public bool IsVpn { get; set; }
    }

    public class AnalyzeResponseTimezoneType
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("abbreviation")]
        public string Abbreviation { get; set; }

        [JsonProperty("gmt_offset")]
        public int GmtOffset { get; set; }

        [JsonProperty("current_time")]
        public string CurrentTime { get; set; }

        [JsonProperty("is_dst")]
        public bool IsDst { get; set; }
    }

    public class AnalyzeResponseFlagType
    {
        [JsonProperty("emoji")]
        public string Emoji { get; set; }

        [JsonProperty("unicode")]
        public string Unicode { get; set; }

        [JsonProperty("png")]
        public string Png { get; set; }

        [JsonProperty("svg")]
        public string Svg { get; set; }
    }

    public class AnalyzeResponseCurrencyType
    {
        [JsonProperty("currency_name")]
        public string CurrencyName { get; set; }

        [JsonProperty("currency_code")]
        public string CurrencyCode { get; set; }
    }

    public class AnalyzeResponseConnectionType
    {
        [JsonProperty("autonomous_system_number")]
        public int AutonomousSystemNumber { get; set; }

        [JsonProperty("autonomous_system_organization")]
        public string AutonomousSystemOrganization { get; set; }

        [JsonProperty("connection_type")]
        public string ConnectionType { get; set; }

        [JsonProperty("isp_name")]
        public string IspName { get; set; }

        [JsonProperty("organization_name")]
        public string OrganizationName { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Abstractipgeolocatio;

    public partial class WorkflowManagedActions
    {
        public AbstractipgeolocatioActions Abstractipgeolocatio(string connectionId) => new AbstractipgeolocatioActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public AbstractipgeolocatioTriggers Abstractipgeolocatio(string connectionId) => new AbstractipgeolocatioTriggers(connectionId);
    }
}