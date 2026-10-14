//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------
namespace Microsoft.Azure.Workflows.Sdk.Connectors.Aplaceioip
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;
    using System.Linq.Expressions;

    public class AplaceioipActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "aplaceioip")]
        public IBodyWorkflowAction<SearchGetResponse> SearchGet(Expression<Func<string>> q, Expression<Func<string>> sessionId = null, Expression<Func<typeInput>> type = null, Expression<Func<string>> countries = null, Expression<Func<double>> lat = null, Expression<Func<double>> lon = null, Expression<Func<double>> radius = null, Expression<Func<string>> lang = null)
        {
            var __workflow_q = q == null ? null : WorkflowExpression.Compile(q);
            WorkflowExpression.Validate(__workflow_q, nameof(q), required: true);
            var __workflow_sessionId = sessionId == null ? null : WorkflowExpression.Compile(sessionId);
            WorkflowExpression.Validate(__workflow_sessionId, nameof(sessionId), required: false);
            var __workflow_type = type == null ? null : WorkflowExpression.Compile(type);
            WorkflowExpression.Validate(__workflow_type, nameof(type), required: false);
            var __workflow_countries = countries == null ? null : WorkflowExpression.Compile(countries);
            WorkflowExpression.Validate(__workflow_countries, nameof(countries), required: false);
            var __workflow_lat = lat == null ? null : WorkflowExpression.Compile(lat);
            WorkflowExpression.Validate(__workflow_lat, nameof(lat), required: false);
            var __workflow_lon = lon == null ? null : WorkflowExpression.Compile(lon);
            WorkflowExpression.Validate(__workflow_lon, nameof(lon), required: false);
            var __workflow_radius = radius == null ? null : WorkflowExpression.Compile(radius);
            WorkflowExpression.Validate(__workflow_radius, nameof(radius), required: false);
            var __workflow_lang = lang == null ? null : WorkflowExpression.Compile(lang);
            WorkflowExpression.Validate(__workflow_lang, nameof(lang), required: false);
            return new DeferredBodyAction<SearchGetResponse>(() =>
            {
                var apiCallPath = "/search";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["q"] = ExpressionConverter.Convert(__workflow_q);
                if (__workflow_sessionId != null)
                    callPayload.Queries["session_id"] = ExpressionConverter.Convert(__workflow_sessionId);
                if (__workflow_type != null)
                    callPayload.Queries["type"] = ExpressionConverter.Convert(__workflow_type);
                if (__workflow_countries != null)
                    callPayload.Queries["countries"] = ExpressionConverter.Convert(__workflow_countries);
                if (__workflow_lat != null)
                    callPayload.Queries["lat"] = ExpressionConverter.Convert(__workflow_lat);
                if (__workflow_lon != null)
                    callPayload.Queries["lon"] = ExpressionConverter.Convert(__workflow_lon);
                if (__workflow_radius != null)
                    callPayload.Queries["radius"] = ExpressionConverter.Convert(__workflow_radius);
                if (__workflow_lang != null)
                    callPayload.Queries["lang"] = ExpressionConverter.Convert(__workflow_lang);
                return new ApiConnectionAction<SearchGetResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "aplaceioip")]
        public IBodyWorkflowAction<PIPGetResponse> PIPGet(Expression<Func<double>> lat = null, Expression<Func<double>> lon = null)
        {
            var __workflow_lat = lat == null ? null : WorkflowExpression.Compile(lat);
            WorkflowExpression.Validate(__workflow_lat, nameof(lat), required: false);
            var __workflow_lon = lon == null ? null : WorkflowExpression.Compile(lon);
            WorkflowExpression.Validate(__workflow_lon, nameof(lon), required: false);
            return new DeferredBodyAction<PIPGetResponse>(() =>
            {
                var apiCallPath = "/pip";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_lat != null)
                    callPayload.Queries["lat"] = ExpressionConverter.Convert(__workflow_lat);
                if (__workflow_lon != null)
                    callPayload.Queries["lon"] = ExpressionConverter.Convert(__workflow_lon);
                return new ApiConnectionAction<PIPGetResponse>(callPayload);
            });
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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
