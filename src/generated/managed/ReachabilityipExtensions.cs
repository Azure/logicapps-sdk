//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Reachabilityip
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class ReachabilityipActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "reachabilityip")]
        public IBodyWorkflowAction<ReachResponse> Reach(Expression<Func<string>> url, Expression<Func<string>> country = null)
        {
            var apiCallPath = "/reachability";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["url"] = ExpressionConverter.Convert(url);
            if (country != null)
                callPayload.Queries["country"] = ExpressionConverter.Convert(country);
            return new ApiConnectionAction<ReachResponse>(callPayload);
        }
    }

    public class ReachabilityipTriggers([ConnectionName] string connectionId)
    {
    }

    public class ReachResponse
    {
        [JsonProperty("status_code")]
        public int StatusCode { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("ip_data")]
        public ReachResponseIpDataType IpData { get; set; }
    }

    public class ReachResponseIpDataType
    {
        [JsonProperty("ip")]
        public string Ip { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("asn")]
        public ReachResponseIpDataTypeAsnType Asn { get; set; }

        [JsonProperty("geo")]
        public ReachResponseIpDataTypeGeoType Geo { get; set; }
    }

    public class ReachResponseIpDataTypeAsnType
    {
        [JsonProperty("asnum")]
        public int Asnum { get; set; }

        [JsonProperty("org_name")]
        public string OrgName { get; set; }
    }

    public class ReachResponseIpDataTypeGeoType
    {
        [JsonProperty("city")]
        public string City { get; set; }

        [JsonProperty("region")]
        public string Region { get; set; }

        [JsonProperty("region_name")]
        public string RegionName { get; set; }

        [JsonProperty("postal_code")]
        public string PostalCode { get; set; }

        [JsonProperty("latitude")]
        public double Latitude { get; set; }

        [JsonProperty("longitude")]
        public double Longitude { get; set; }

        [JsonProperty("tz")]
        public string Tz { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Reachabilityip;

    public partial class WorkflowManagedActions
    {
        public ReachabilityipActions Reachabilityip(string connectionId) => new ReachabilityipActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public ReachabilityipTriggers Reachabilityip(string connectionId) => new ReachabilityipTriggers(connectionId);
    }
}