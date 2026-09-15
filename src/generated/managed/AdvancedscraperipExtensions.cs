//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Advancedscraperip
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class AdvancedscraperipActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "advancedscraperip")]
        public IBodyWorkflowAction<ScrapeResponse> Scrape(Expression<Func<string>> url, Expression<Func<string>> country = null, Expression<Func<bool>> render = null, Expression<Func<string>> selector = null, Expression<Func<int>> timeout = null)
        {
            var apiCallPath = "/scraper";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["url"] = CSharpExpressionConverter.ConvertO(url);
            if (country != null)
                callPayload.Queries["country"] = CSharpExpressionConverter.ConvertO(country);
            if (render != null)
                callPayload.Queries["render"] = CSharpExpressionConverter.ConvertO(render);
            if (selector != null)
                callPayload.Queries["selector"] = CSharpExpressionConverter.ConvertO(selector);
            if (timeout != null)
                callPayload.Queries["timeout"] = CSharpExpressionConverter.ConvertO(timeout);
            return new ApiConnectionAction<ScrapeResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "advancedscraperip")]
        public IBodyWorkflowAction<ScrapeFormResponse> ScrapeForm(Expression<Func<string>> url, Expression<Func<string>> country = null, Expression<Func<bool>> render = null, Expression<Func<string>> selector = null, Expression<Func<int>> timeout = null, Expression<Func<string>> body = null)
        {
            var apiCallPath = "/scraper";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["url"] = CSharpExpressionConverter.ConvertO(url);
            if (country != null)
                callPayload.Queries["country"] = CSharpExpressionConverter.ConvertO(country);
            if (render != null)
                callPayload.Queries["render"] = CSharpExpressionConverter.ConvertO(render);
            if (selector != null)
                callPayload.Queries["selector"] = CSharpExpressionConverter.ConvertO(selector);
            if (timeout != null)
                callPayload.Queries["timeout"] = CSharpExpressionConverter.ConvertO(timeout);
            callPayload.Body = CSharpExpressionConverter.ConvertToken(body);
            return new ApiConnectionAction<ScrapeFormResponse>(callPayload);
        }
    }

    public class AdvancedscraperipTriggers([ConnectionName] string connectionId)
    {
    }

    public class ScrapeResponse
    {
        [JsonProperty("data-selector")]
        public string[] DataSelector { get; set; }

        [JsonProperty("options")]
        public ScrapeResponseOptionsType Options { get; set; }

        [JsonProperty("page_title")]
        public string PageTitle { get; set; }

        [JsonProperty("result_url")]
        public string ResultUrl { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }
    }

    public class ScrapeResponseOptionsType
    {
        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("render")]
        public bool Render { get; set; }

        [JsonProperty("selector")]
        public string Selector { get; set; }

        [JsonProperty("timeout")]
        public int Timeout { get; set; }
    }

    public class ScrapeFormResponse
    {
        [JsonProperty("data-selector")]
        public string[] DataSelector { get; set; }

        [JsonProperty("options")]
        public ScrapeFormResponseOptionsType Options { get; set; }

        [JsonProperty("page_title")]
        public string PageTitle { get; set; }

        [JsonProperty("request_headers")]
        public ScrapeFormResponseRequestHeadersType RequestHeaders { get; set; }

        [JsonProperty("result_url")]
        public string ResultUrl { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }
    }

    public class ScrapeFormResponseOptionsType
    {
        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("render")]
        public bool Render { get; set; }

        [JsonProperty("selector")]
        public string Selector { get; set; }

        [JsonProperty("timeout")]
        public int Timeout { get; set; }
    }

    public class ScrapeFormResponseRequestHeadersType
    {
        public string Referer { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Advancedscraperip;

    public partial class WorkflowManagedActions
    {
        public AdvancedscraperipActions Advancedscraperip(string connectionId) => new AdvancedscraperipActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public AdvancedscraperipTriggers Advancedscraperip(string connectionId) => new AdvancedscraperipTriggers(connectionId);
    }
}