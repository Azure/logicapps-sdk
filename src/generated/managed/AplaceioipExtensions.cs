//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Aplaceioip
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class AplaceioipActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "aplaceioip")]
        public IBodyWorkflowAction<SearchGetResponse> SearchGet(Expression<Func<string>> q, Expression<Func<string>> sessionId = null, Expression<Func<typeInput>> type = null, Expression<Func<string>> countries = null, Expression<Func<double>> lat = null, Expression<Func<double>> lon = null, Expression<Func<double>> radius = null, Expression<Func<string>> lang = null)
        {
            var apiCallPath = "/search";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["q"] = CSharpExpressionConverter.ConvertO(q);
            if (sessionId != null)
                callPayload.Queries["session_id"] = CSharpExpressionConverter.ConvertO(sessionId);
            if (type != null)
                callPayload.Queries["type"] = CSharpExpressionConverter.Convert(type);
            if (countries != null)
                callPayload.Queries["countries"] = CSharpExpressionConverter.ConvertO(countries);
            if (lat != null)
                callPayload.Queries["lat"] = CSharpExpressionConverter.ConvertO(lat);
            if (lon != null)
                callPayload.Queries["lon"] = CSharpExpressionConverter.ConvertO(lon);
            if (radius != null)
                callPayload.Queries["radius"] = CSharpExpressionConverter.ConvertO(radius);
            if (lang != null)
                callPayload.Queries["lang"] = CSharpExpressionConverter.ConvertO(lang);
            return new ApiConnectionAction<SearchGetResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "aplaceioip")]
        public IBodyWorkflowAction<PIPGetResponse> PIPGet(Expression<Func<double>> lat = null, Expression<Func<double>> lon = null)
        {
            var apiCallPath = "/pip";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (lat != null)
                callPayload.Queries["lat"] = CSharpExpressionConverter.ConvertO(lat);
            if (lon != null)
                callPayload.Queries["lon"] = CSharpExpressionConverter.ConvertO(lon);
            return new ApiConnectionAction<PIPGetResponse>(callPayload);
        }
    }

    public class AplaceioipTriggers([ConnectionName] string connectionId)
    {
    }

    public class SearchGetResponse
    {
        [JsonProperty("session_id")]
        public string SessionId { get; set; }

        [JsonProperty("data")]
        public SearchGetResponseDataTypeItem[] Data { get; set; }
    }

    public class SearchGetResponseDataTypeItem
    {
        [JsonProperty("score")]
        public double Score { get; set; }

        [JsonProperty("match")]
        public string Match { get; set; }

        [JsonProperty("match_details")]
        public string MatchDetails { get; set; }

        [JsonProperty("lat")]
        public double Lat { get; set; }

        [JsonProperty("lon")]
        public double Lon { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("address")]
        public SearchGetResponseDataTypeItemAddressType Address { get; set; }

        [JsonProperty("debug")]
        public SearchGetResponseDataTypeItemDebugType Debug { get; set; }
    }

    public class SearchGetResponseDataTypeItemAddressType
    {
        [JsonProperty("house_number")]
        public string HouseNumber { get; set; }

        [JsonProperty("road")]
        public string Road { get; set; }

        [JsonProperty("quarter")]
        public string Quarter { get; set; }

        [JsonProperty("city")]
        public string City { get; set; }

        [JsonProperty("postcode")]
        public string Postcode { get; set; }

        [JsonProperty("county")]
        public string County { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("state_code")]
        public string StateCode { get; set; }

        [JsonProperty("region")]
        public string Region { get; set; }

        [JsonProperty("region_code")]
        public string RegionCode { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("country_code")]
        public string CountryCode { get; set; }
    }

    public class SearchGetResponseDataTypeItemDebugType
    {
        [JsonProperty("custom_score_norm")]
        public string CustomScoreNorm { get; set; }

        [JsonProperty("from")]
        public string From { get; set; }
    }

    public enum typeInput
    {
        [EnumMember(Value = "house_number")]
        HouseNumber,
        [EnumMember(Value = "road")]
        Road,
        [EnumMember(Value = "quarter")]
        Quarter,
        [EnumMember(Value = "city")]
        City,
        [EnumMember(Value = "county")]
        County,
        [EnumMember(Value = "state")]
        State,
        [EnumMember(Value = "region")]
        Region,
        [EnumMember(Value = "country")]
        Country
    }

    public class PIPGetResponse
    {
        [JsonProperty("session_id")]
        public string SessionId { get; set; }

        [JsonProperty("data")]
        public PIPGetResponseDataTypeItem[] Data { get; set; }
    }

    public class PIPGetResponseDataTypeItem
    {
        [JsonProperty("score")]
        public int Score { get; set; }

        [JsonProperty("match")]
        public string Match { get; set; }

        [JsonProperty("match_details")]
        public string MatchDetails { get; set; }

        [JsonProperty("lat")]
        public double Lat { get; set; }

        [JsonProperty("lon")]
        public double Lon { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("address")]
        public PIPGetResponseDataTypeItemAddressType Address { get; set; }
    }

    public class PIPGetResponseDataTypeItemAddressType
    {
        [JsonProperty("house_number")]
        public string HouseNumber { get; set; }

        [JsonProperty("road")]
        public string Road { get; set; }

        [JsonProperty("quarter")]
        public string Quarter { get; set; }

        [JsonProperty("city")]
        public string City { get; set; }

        [JsonProperty("postcode")]
        public string Postcode { get; set; }

        [JsonProperty("county")]
        public string County { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("region")]
        public string Region { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("country_code")]
        public string CountryCode { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Aplaceioip;

    public partial class WorkflowManagedActions
    {
        public AplaceioipActions Aplaceioip(string connectionId) => new AplaceioipActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public AplaceioipTriggers Aplaceioip(string connectionId) => new AplaceioipTriggers(connectionId);
    }
}