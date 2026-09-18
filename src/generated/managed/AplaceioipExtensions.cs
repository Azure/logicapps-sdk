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
        public IBodyWorkflowAction<SearchGetResponse> SearchGet([WorkflowExpression] Func<string> q, [WorkflowExpression] Func<string> sessionId = null, [WorkflowExpression] Func<typeInput> type = null, [WorkflowExpression] Func<string> countries = null, [WorkflowExpression] Func<double> lat = null, [WorkflowExpression] Func<double> lon = null, [WorkflowExpression] Func<double> radius = null, [WorkflowExpression] Func<string> lang = null)
        {
            SourceExpression.Validate(q, nameof(q), required: true);
            SourceExpression.Validate(sessionId, nameof(sessionId), required: false);
            SourceExpression.Validate(type, nameof(type), required: false);
            SourceExpression.Validate(countries, nameof(countries), required: false);
            SourceExpression.Validate(lat, nameof(lat), required: false);
            SourceExpression.Validate(lon, nameof(lon), required: false);
            SourceExpression.Validate(radius, nameof(radius), required: false);
            SourceExpression.Validate(lang, nameof(lang), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/search";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["q"] = SourceExpressionConverter.ConvertO(q);
                if (sessionId != null)
                    callPayload.Queries["session_id"] = SourceExpressionConverter.ConvertO(sessionId);
                if (type != null)
                    callPayload.Queries["type"] = SourceExpressionConverter.Convert(type);
                if (countries != null)
                    callPayload.Queries["countries"] = SourceExpressionConverter.ConvertO(countries);
                if (lat != null)
                    callPayload.Queries["lat"] = SourceExpressionConverter.ConvertO(lat);
                if (lon != null)
                    callPayload.Queries["lon"] = SourceExpressionConverter.ConvertO(lon);
                if (radius != null)
                    callPayload.Queries["radius"] = SourceExpressionConverter.ConvertO(radius);
                if (lang != null)
                    callPayload.Queries["lang"] = SourceExpressionConverter.ConvertO(lang);
                return callPayload;
            }

            return new ApiConnectionAction<SearchGetResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "aplaceioip")]
        public IBodyWorkflowAction<PIPGetResponse> PIPGet([WorkflowExpression] Func<double> lat = null, [WorkflowExpression] Func<double> lon = null)
        {
            SourceExpression.Validate(lat, nameof(lat), required: false);
            SourceExpression.Validate(lon, nameof(lon), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/pip";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (lat != null)
                    callPayload.Queries["lat"] = SourceExpressionConverter.ConvertO(lat);
                if (lon != null)
                    callPayload.Queries["lon"] = SourceExpressionConverter.ConvertO(lon);
                return callPayload;
            }

            return new ApiConnectionAction<PIPGetResponse>(BuildSourceInput);
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