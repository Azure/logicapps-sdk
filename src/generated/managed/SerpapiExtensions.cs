//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Serpapi
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class SerpapiActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "serpapi")]
        public IBodyWorkflowAction<GoogleSearchResponse> GoogleSearch([WorkflowExpression] Func<string> q, [WorkflowExpression] Func<string> location = null, [WorkflowExpression] Func<string> uule = null, [WorkflowExpression] Func<double> lat = null, [WorkflowExpression] Func<double> lon = null, [WorkflowExpression] Func<int> radius = null, [WorkflowExpression] Func<string> googleDomain = null, [WorkflowExpression] Func<string> gl = null, [WorkflowExpression] Func<string> hl = null, [WorkflowExpression] Func<string> cr = null, [WorkflowExpression] Func<string> lr = null, [WorkflowExpression] Func<string> tbs = null, [WorkflowExpression] Func<safeInput> safe = null, [WorkflowExpression] Func<nfprInput> nfpr = null, [WorkflowExpression] Func<filterInput> filter = null, [WorkflowExpression] Func<tbmInput> tbm = null, [WorkflowExpression] Func<int> start = null, [WorkflowExpression] Func<deviceInput> device = null, [WorkflowExpression] Func<bool> noCache = null, [WorkflowExpression] Func<bool> async = null, [WorkflowExpression] Func<outputInput> output = null, [WorkflowExpression] Func<string> ludocid = null, [WorkflowExpression] Func<string> kgmid = null, [WorkflowExpression] Func<string> lsig = null, [WorkflowExpression] Func<string> si = null, [WorkflowExpression] Func<string> ibp = null, [WorkflowExpression] Func<string> uds = null, [WorkflowExpression] Func<bool> zeroTrace = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/search.json";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["q"] = SourceExpressionConverter.ConvertO(q);
                if (location != null)
                    callPayload.Queries["location"] = SourceExpressionConverter.ConvertO(location);
                if (uule != null)
                    callPayload.Queries["uule"] = SourceExpressionConverter.ConvertO(uule);
                if (lat != null)
                    callPayload.Queries["lat"] = SourceExpressionConverter.ConvertO(lat);
                if (lon != null)
                    callPayload.Queries["lon"] = SourceExpressionConverter.ConvertO(lon);
                if (radius != null)
                    callPayload.Queries["radius"] = SourceExpressionConverter.ConvertO(radius);
                if (googleDomain != null)
                    callPayload.Queries["google_domain"] = SourceExpressionConverter.ConvertO(googleDomain);
                if (gl != null)
                    callPayload.Queries["gl"] = SourceExpressionConverter.ConvertO(gl);
                if (hl != null)
                    callPayload.Queries["hl"] = SourceExpressionConverter.ConvertO(hl);
                if (cr != null)
                    callPayload.Queries["cr"] = SourceExpressionConverter.ConvertO(cr);
                if (lr != null)
                    callPayload.Queries["lr"] = SourceExpressionConverter.ConvertO(lr);
                if (tbs != null)
                    callPayload.Queries["tbs"] = SourceExpressionConverter.ConvertO(tbs);
                if (safe != null)
                    callPayload.Queries["safe"] = SourceExpressionConverter.Convert(safe);
                if (nfpr != null)
                    callPayload.Queries["nfpr"] = SourceExpressionConverter.Convert(nfpr);
                if (filter != null)
                    callPayload.Queries["filter"] = SourceExpressionConverter.Convert(filter);
                if (tbm != null)
                    callPayload.Queries["tbm"] = SourceExpressionConverter.Convert(tbm);
                if (start != null)
                    callPayload.Queries["start"] = SourceExpressionConverter.ConvertO(start);
                if (device != null)
                    callPayload.Queries["device"] = SourceExpressionConverter.Convert(device);
                if (noCache != null)
                    callPayload.Queries["no_cache"] = SourceExpressionConverter.ConvertO(noCache);
                if (async != null)
                    callPayload.Queries["async"] = SourceExpressionConverter.ConvertO(async);
                if (output != null)
                    callPayload.Queries["output"] = SourceExpressionConverter.Convert(output);
                if (ludocid != null)
                    callPayload.Queries["ludocid"] = SourceExpressionConverter.ConvertO(ludocid);
                if (kgmid != null)
                    callPayload.Queries["kgmid"] = SourceExpressionConverter.ConvertO(kgmid);
                if (lsig != null)
                    callPayload.Queries["lsig"] = SourceExpressionConverter.ConvertO(lsig);
                if (si != null)
                    callPayload.Queries["si"] = SourceExpressionConverter.ConvertO(si);
                if (ibp != null)
                    callPayload.Queries["ibp"] = SourceExpressionConverter.ConvertO(ibp);
                if (uds != null)
                    callPayload.Queries["uds"] = SourceExpressionConverter.ConvertO(uds);
                if (zeroTrace != null)
                    callPayload.Queries["zero_trace"] = SourceExpressionConverter.ConvertO(zeroTrace);
                return callPayload;
            }

            return new ApiConnectionAction<GoogleSearchResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "serpapi")]
        public IBodyWorkflowAction<Location[]> GetLocations([WorkflowExpression] Func<string> q = null, [WorkflowExpression] Func<int> limit = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/locations.json";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (q != null)
                    callPayload.Queries["q"] = SourceExpressionConverter.ConvertO(q);
                if (limit != null)
                    callPayload.Queries["limit"] = SourceExpressionConverter.ConvertO(limit);
                return callPayload;
            }

            return new ApiConnectionAction<Location[]>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "serpapi")]
        public IBodyWorkflowAction<AccountInfo> GetAccount()
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/account";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<AccountInfo>(BuildSourceInput);
        }
    }

    public class SerpapiTriggers([ConnectionName] string connectionId)
    {
    }

    public class GoogleSearchResponse
    {
        [JsonProperty("search_metadata")]
        public JToken SearchMetadata { get; set; }

        [JsonProperty("search_parameters")]
        public JToken SearchParameters { get; set; }

        [JsonProperty("search_information")]
        public JToken SearchInformation { get; set; }

        [JsonProperty("organic_results")]
        public JToken[] OrganicResults { get; set; }

        [JsonProperty("ads")]
        public JToken[] Ads { get; set; }

        [JsonProperty("knowledge_graph")]
        public JToken KnowledgeGraph { get; set; }

        [JsonProperty("related_questions")]
        public JToken[] RelatedQuestions { get; set; }

        [JsonProperty("related_searches")]
        public JToken[] RelatedSearches { get; set; }

        [JsonProperty("local_results")]
        public JToken LocalResults { get; set; }

        [JsonProperty("top_stories")]
        public JToken[] TopStories { get; set; }

        [JsonProperty("pagination")]
        public JToken Pagination { get; set; }
    }

    public enum safeInput
    {
        [EnumMember(Value = "active")]
        Active,
        [EnumMember(Value = "off")]
        Off
    }

    public enum nfprInput
    {
        _0 = 0,
        _1 = 1
    }

    public enum filterInput
    {
        _0 = 0,
        _1 = 1
    }

    public enum tbmInput
    {
        [EnumMember(Value = "isch")]
        Isch,
        [EnumMember(Value = "lcl")]
        Lcl,
        [EnumMember(Value = "vid")]
        Vid,
        [EnumMember(Value = "nws")]
        Nws,
        [EnumMember(Value = "shop")]
        Shop,
        [EnumMember(Value = "pts")]
        Pts
    }

    public enum deviceInput
    {
        [EnumMember(Value = "desktop")]
        Desktop,
        [EnumMember(Value = "tablet")]
        Tablet,
        [EnumMember(Value = "mobile")]
        Mobile
    }

    public enum outputInput
    {
        [EnumMember(Value = "json")]
        Json,
        [EnumMember(Value = "html")]
        Html
    }

    public class Location
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("canonical_name")]
        public string CanonicalName { get; set; }

        [JsonProperty("country_code")]
        public string CountryCode { get; set; }

        [JsonProperty("target_type")]
        public string TargetType { get; set; }

        [JsonProperty("reach")]
        public int Reach { get; set; }

        [JsonProperty("gps")]
        public double[] Gps { get; set; }
    }

    public class AccountInfo
    {
        [JsonProperty("account_id")]
        public string AccountId { get; set; }

        [JsonProperty("api_key")]
        public string ApiKey { get; set; }

        [JsonProperty("account_email")]
        public string AccountEmail { get; set; }

        [JsonProperty("plan_name")]
        public string PlanName { get; set; }

        [JsonProperty("plan_monthly_price")]
        public double PlanMonthlyPrice { get; set; }

        [JsonProperty("searches_per_month")]
        public int SearchesPerMonth { get; set; }

        [JsonProperty("plan_searches_left")]
        public int PlanSearchesLeft { get; set; }

        [JsonProperty("extra_credits")]
        public int ExtraCredits { get; set; }

        [JsonProperty("account_rate_limit_per_hour")]
        public int AccountRateLimitPerHour { get; set; }

        [JsonProperty("this_month_usage")]
        public int ThisMonthUsage { get; set; }

        [JsonProperty("this_hour_searches")]
        public int ThisHourSearches { get; set; }

        [JsonProperty("last_hour_searches")]
        public int LastHourSearches { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Serpapi;

    public partial class WorkflowManagedActions
    {
        public SerpapiActions Serpapi(string connectionId) => new SerpapiActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public SerpapiTriggers Serpapi(string connectionId) => new SerpapiTriggers(connectionId);
    }
}