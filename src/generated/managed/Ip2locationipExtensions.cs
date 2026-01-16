//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Ip2locationip
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class Ip2locationipActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ip2locationip")]
        public IBodyWorkflowAction<LookupIpResponse> LookupIp(Expression<Func<string>> ip)
        {
            var apiCallPath = "/";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["ip"] = ExpressionConverter.Convert(ip);
            return new ApiConnectionAction<LookupIpResponse>(callPayload);
        }
    }

    public class Ip2locationipTriggers([ConnectionName] string connectionId)
    {
    }

    public class LookupIpResponse
    {
        [JsonProperty("ip")]
        public string Ip { get; set; }

        [JsonProperty("country_code")]
        public string CountryCode { get; set; }

        [JsonProperty("country_name")]
        public string CountryName { get; set; }

        [JsonProperty("region_name")]
        public string RegionName { get; set; }

        [JsonProperty("city_name")]
        public string CityName { get; set; }

        [JsonProperty("latitude")]
        public double Latitude { get; set; }

        [JsonProperty("longitude")]
        public double Longitude { get; set; }

        [JsonProperty("zip_code")]
        public string ZipCode { get; set; }

        [JsonProperty("time_zone")]
        public string TimeZone { get; set; }

        [JsonProperty("asn")]
        public string Asn { get; set; }

        [JsonProperty("as")]
        public string As { get; set; }

        [JsonProperty("isp")]
        public string Isp { get; set; }

        [JsonProperty("domain")]
        public string Domain { get; set; }

        [JsonProperty("net_speed")]
        public string NetSpeed { get; set; }

        [JsonProperty("idd_code")]
        public string IddCode { get; set; }

        [JsonProperty("area_code")]
        public string AreaCode { get; set; }

        [JsonProperty("weather_station_code")]
        public string WeatherStationCode { get; set; }

        [JsonProperty("weather_station_name")]
        public string WeatherStationName { get; set; }

        [JsonProperty("mcc")]
        public string Mcc { get; set; }

        [JsonProperty("mnc")]
        public string Mnc { get; set; }

        [JsonProperty("mobile_brand")]
        public string MobileBrand { get; set; }

        [JsonProperty("elevation")]
        public int Elevation { get; set; }

        [JsonProperty("usage_type")]
        public string UsageType { get; set; }

        [JsonProperty("address_type")]
        public string AddressType { get; set; }

        [JsonProperty("continent")]
        public LookupIpResponseContinentType Continent { get; set; }

        [JsonProperty("country")]
        public LookupIpResponseCountryType Country { get; set; }

        [JsonProperty("region")]
        public LookupIpResponseRegionType Region { get; set; }

        [JsonProperty("city")]
        public LookupIpResponseCityType City { get; set; }

        [JsonProperty("time_zone_info")]
        public LookupIpResponseTimeZoneInfoType TimeZoneInfo { get; set; }

        [JsonProperty("ads_category")]
        public string AdsCategory { get; set; }

        [JsonProperty("ads_category_name")]
        public string AdsCategoryName { get; set; }

        [JsonProperty("district")]
        public string District { get; set; }

        [JsonProperty("is_proxy")]
        public bool IsProxy { get; set; }

        [JsonProperty("proxy")]
        public LookupIpResponseProxyType Proxy { get; set; }
    }

    public class LookupIpResponseContinentType
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("hemisphere")]
        public string[] Hemisphere { get; set; }
    }

    public class LookupIpResponseCountryType
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("alpha3_code")]
        public string Alpha3Code { get; set; }

        [JsonProperty("numeric_code")]
        public int NumericCode { get; set; }

        [JsonProperty("demonym")]
        public string Demonym { get; set; }

        [JsonProperty("flag")]
        public string Flag { get; set; }

        [JsonProperty("capital")]
        public string Capital { get; set; }

        [JsonProperty("total_area")]
        public int TotalArea { get; set; }

        [JsonProperty("population")]
        public int Population { get; set; }

        [JsonProperty("currency")]
        public LookupIpResponseCountryTypeCurrencyType Currency { get; set; }

        [JsonProperty("language")]
        public LookupIpResponseCountryTypeLanguageType Language { get; set; }

        [JsonProperty("tld")]
        public string Tld { get; set; }
    }

    public class LookupIpResponseCountryTypeCurrencyType
    {
        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("symbol")]
        public string Symbol { get; set; }
    }

    public class LookupIpResponseCountryTypeLanguageType
    {
        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class LookupIpResponseRegionType
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }
    }

    public class LookupIpResponseCityType
    {
        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class LookupIpResponseTimeZoneInfoType
    {
        [JsonProperty("olson")]
        public string Olson { get; set; }

        [JsonProperty("current_time")]
        public string CurrentTime { get; set; }

        [JsonProperty("gmt_offset")]
        public int GmtOffset { get; set; }

        [JsonProperty("is_dst")]
        public bool IsDst { get; set; }

        [JsonProperty("sunrise")]
        public string Sunrise { get; set; }

        [JsonProperty("sunset")]
        public string Sunset { get; set; }
    }

    public class LookupIpResponseProxyType
    {
        [JsonProperty("last_seen")]
        public int LastSeen { get; set; }

        [JsonProperty("proxy_type")]
        public string ProxyType { get; set; }

        [JsonProperty("threat")]
        public string Threat { get; set; }

        [JsonProperty("provider")]
        public string Provider { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk.Connectors
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Ip2locationip;

    public partial class WorkflowManagedActions
    {
        public Ip2locationipActions Ip2locationip(string connectionId) => new Ip2locationipActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public Ip2locationipTriggers Ip2locationip(string connectionId) => new Ip2locationipTriggers(connectionId);
    }
}