//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Serpapi
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class SerpapiActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "serpapi")]
        public IBodyWorkflowAction<GoogleSearchResponse, ApiConnectionActionConfiguration> GoogleSearch(Expression<Func<string>> q, Expression<Func<string>> location = null, Expression<Func<string>> uule = null, Expression<Func<double>> lat = null, Expression<Func<double>> lon = null, Expression<Func<int>> radius = null, Expression<Func<string>> googleDomain = null, Expression<Func<string>> gl = null, Expression<Func<string>> hl = null, Expression<Func<string>> cr = null, Expression<Func<string>> lr = null, Expression<Func<string>> tbs = null, Expression<Func<safeInput>> safe = null, Expression<Func<nfprInput>> nfpr = null, Expression<Func<filterInput>> filter = null, Expression<Func<tbmInput>> tbm = null, Expression<Func<int>> start = null, Expression<Func<deviceInput>> device = null, Expression<Func<bool>> noCache = null, Expression<Func<bool>> async = null, Expression<Func<outputInput>> output = null, Expression<Func<string>> ludocid = null, Expression<Func<string>> kgmid = null, Expression<Func<string>> lsig = null, Expression<Func<string>> si = null, Expression<Func<string>> ibp = null, Expression<Func<string>> uds = null, Expression<Func<bool>> zeroTrace = null)
        {
            var __workflow_q = WorkflowExpression.Compile(q, nameof(q), required: true);
            var __workflow_location = WorkflowExpression.Compile(location, nameof(location), required: false);
            var __workflow_uule = WorkflowExpression.Compile(uule, nameof(uule), required: false);
            var __workflow_lat = WorkflowExpression.Compile(lat, nameof(lat), required: false);
            var __workflow_lon = WorkflowExpression.Compile(lon, nameof(lon), required: false);
            var __workflow_radius = WorkflowExpression.Compile(radius, nameof(radius), required: false);
            var __workflow_googleDomain = WorkflowExpression.Compile(googleDomain, nameof(googleDomain), required: false);
            var __workflow_gl = WorkflowExpression.Compile(gl, nameof(gl), required: false);
            var __workflow_hl = WorkflowExpression.Compile(hl, nameof(hl), required: false);
            var __workflow_cr = WorkflowExpression.Compile(cr, nameof(cr), required: false);
            var __workflow_lr = WorkflowExpression.Compile(lr, nameof(lr), required: false);
            var __workflow_tbs = WorkflowExpression.Compile(tbs, nameof(tbs), required: false);
            var __workflow_safe = WorkflowExpression.Compile(safe, nameof(safe), required: false);
            var __workflow_nfpr = WorkflowExpression.Compile(nfpr, nameof(nfpr), required: false);
            var __workflow_filter = WorkflowExpression.Compile(filter, nameof(filter), required: false);
            var __workflow_tbm = WorkflowExpression.Compile(tbm, nameof(tbm), required: false);
            var __workflow_start = WorkflowExpression.Compile(start, nameof(start), required: false);
            var __workflow_device = WorkflowExpression.Compile(device, nameof(device), required: false);
            var __workflow_noCache = WorkflowExpression.Compile(noCache, nameof(noCache), required: false);
            var __workflow_async = WorkflowExpression.Compile(async, nameof(async), required: false);
            var __workflow_output = WorkflowExpression.Compile(output, nameof(output), required: false);
            var __workflow_ludocid = WorkflowExpression.Compile(ludocid, nameof(ludocid), required: false);
            var __workflow_kgmid = WorkflowExpression.Compile(kgmid, nameof(kgmid), required: false);
            var __workflow_lsig = WorkflowExpression.Compile(lsig, nameof(lsig), required: false);
            var __workflow_si = WorkflowExpression.Compile(si, nameof(si), required: false);
            var __workflow_ibp = WorkflowExpression.Compile(ibp, nameof(ibp), required: false);
            var __workflow_uds = WorkflowExpression.Compile(uds, nameof(uds), required: false);
            var __workflow_zeroTrace = WorkflowExpression.Compile(zeroTrace, nameof(zeroTrace), required: false);
            return new DeferredBodyAction<GoogleSearchResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/search.json";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["q"] = ExpressionConverter.Convert(__workflow_q);
                if (__workflow_location != null)
                    callPayload.Queries["location"] = ExpressionConverter.Convert(__workflow_location);
                if (__workflow_uule != null)
                    callPayload.Queries["uule"] = ExpressionConverter.Convert(__workflow_uule);
                if (__workflow_lat != null)
                    callPayload.Queries["lat"] = ExpressionConverter.Convert(__workflow_lat);
                if (__workflow_lon != null)
                    callPayload.Queries["lon"] = ExpressionConverter.Convert(__workflow_lon);
                if (__workflow_radius != null)
                    callPayload.Queries["radius"] = ExpressionConverter.Convert(__workflow_radius);
                if (__workflow_googleDomain != null)
                    callPayload.Queries["google_domain"] = ExpressionConverter.Convert(__workflow_googleDomain);
                if (__workflow_gl != null)
                    callPayload.Queries["gl"] = ExpressionConverter.Convert(__workflow_gl);
                if (__workflow_hl != null)
                    callPayload.Queries["hl"] = ExpressionConverter.Convert(__workflow_hl);
                if (__workflow_cr != null)
                    callPayload.Queries["cr"] = ExpressionConverter.Convert(__workflow_cr);
                if (__workflow_lr != null)
                    callPayload.Queries["lr"] = ExpressionConverter.Convert(__workflow_lr);
                if (__workflow_tbs != null)
                    callPayload.Queries["tbs"] = ExpressionConverter.Convert(__workflow_tbs);
                if (__workflow_safe != null)
                    callPayload.Queries["safe"] = ExpressionConverter.Convert(__workflow_safe);
                if (__workflow_nfpr != null)
                    callPayload.Queries["nfpr"] = ExpressionConverter.Convert(__workflow_nfpr);
                if (__workflow_filter != null)
                    callPayload.Queries["filter"] = ExpressionConverter.Convert(__workflow_filter);
                if (__workflow_tbm != null)
                    callPayload.Queries["tbm"] = ExpressionConverter.Convert(__workflow_tbm);
                if (__workflow_start != null)
                    callPayload.Queries["start"] = ExpressionConverter.Convert(__workflow_start);
                if (__workflow_device != null)
                    callPayload.Queries["device"] = ExpressionConverter.Convert(__workflow_device);
                if (__workflow_noCache != null)
                    callPayload.Queries["no_cache"] = ExpressionConverter.Convert(__workflow_noCache);
                if (__workflow_async != null)
                    callPayload.Queries["async"] = ExpressionConverter.Convert(__workflow_async);
                if (__workflow_output != null)
                    callPayload.Queries["output"] = ExpressionConverter.Convert(__workflow_output);
                if (__workflow_ludocid != null)
                    callPayload.Queries["ludocid"] = ExpressionConverter.Convert(__workflow_ludocid);
                if (__workflow_kgmid != null)
                    callPayload.Queries["kgmid"] = ExpressionConverter.Convert(__workflow_kgmid);
                if (__workflow_lsig != null)
                    callPayload.Queries["lsig"] = ExpressionConverter.Convert(__workflow_lsig);
                if (__workflow_si != null)
                    callPayload.Queries["si"] = ExpressionConverter.Convert(__workflow_si);
                if (__workflow_ibp != null)
                    callPayload.Queries["ibp"] = ExpressionConverter.Convert(__workflow_ibp);
                if (__workflow_uds != null)
                    callPayload.Queries["uds"] = ExpressionConverter.Convert(__workflow_uds);
                if (__workflow_zeroTrace != null)
                    callPayload.Queries["zero_trace"] = ExpressionConverter.Convert(__workflow_zeroTrace);
                return new ApiConnectionAction<GoogleSearchResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "serpapi")]
        public IBodyWorkflowAction<Location[], ApiConnectionActionConfiguration> GetLocations(Expression<Func<string>> q = null, Expression<Func<int>> limit = null)
        {
            var __workflow_q = WorkflowExpression.Compile(q, nameof(q), required: false);
            var __workflow_limit = WorkflowExpression.Compile(limit, nameof(limit), required: false);
            return new DeferredBodyAction<Location[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/locations.json";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_q != null)
                    callPayload.Queries["q"] = ExpressionConverter.Convert(__workflow_q);
                if (__workflow_limit != null)
                    callPayload.Queries["limit"] = ExpressionConverter.Convert(__workflow_limit);
                return new ApiConnectionAction<Location[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "serpapi")]
        public IBodyWorkflowAction<AccountInfo, ApiConnectionActionConfiguration> GetAccount()
        {
            return new DeferredBodyAction<AccountInfo, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/account";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<AccountInfo>(callPayload);
            });
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum deviceInput
    {
        [EnumMember(Value = "desktop")]
        Desktop,
        [EnumMember(Value = "tablet")]
        Tablet,
        [EnumMember(Value = "mobile")]
        Mobile
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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