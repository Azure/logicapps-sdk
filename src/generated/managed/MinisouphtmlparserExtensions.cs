//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Minisouphtmlparser
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class MinisouphtmlparserActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "minisouphtmlparser")]
        public IBodyWorkflowAction<FetchHTMLResponse, ApiConnectionActionConfiguration> FetchHTML(Expression<Func<FetchHTMLBodyInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<FetchHTMLResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/fetch-html";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<FetchHTMLResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "minisouphtmlparser")]
        public IBodyWorkflowAction<SelectElementsResponse, ApiConnectionActionConfiguration> SelectElements(Expression<Func<SelectElementsBodyInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<SelectElementsResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/select";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<SelectElementsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "minisouphtmlparser")]
        public IBodyWorkflowAction<ExtractValuesResponse, ApiConnectionActionConfiguration> ExtractValues(Expression<Func<ExtractValuesBodyInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<ExtractValuesResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/extract";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<ExtractValuesResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "minisouphtmlparser")]
        public IBodyWorkflowAction<FindAllElementsResponse, ApiConnectionActionConfiguration> FindAllElements(Expression<Func<FindAllElementsBodyInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<FindAllElementsResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/find-all";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<FindAllElementsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "minisouphtmlparser")]
        public IBodyWorkflowAction<ParseTableResponse, ApiConnectionActionConfiguration> ParseTable(Expression<Func<ParseTableBodyInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<ParseTableResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/parse-table";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<ParseTableResponse>(callPayload);
            });
        }
    }

    public class MinisouphtmlparserTriggers([ConnectionName] string connectionId)
    {
    }

    public class FetchHTMLResponse
    {
        [JsonProperty("success")]
        public bool Success { get; set; }

        [JsonProperty("html")]
        public string Html { get; set; }
    }

    public class FetchHTMLBodyInput
    {
        public FetchHTMLBodyInput(string url)
        {
            this.Url = url;
        }

        [JsonProperty("operation", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string Operation { get; set; } = "fetch_html";

        [JsonProperty("url", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Url { get; set; }
    }

    public class SelectElementsResponse
    {
        [JsonProperty("success")]
        public bool Success { get; set; }

        [JsonProperty("elements")]
        public HtmlElement[] Elements { get; set; }

        [JsonProperty("count")]
        public int Count { get; set; }
    }

    public class HtmlElement
    {
        [JsonProperty("tag")]
        public string Tag { get; set; }

        [JsonProperty("outerHtml")]
        public string OuterHtml { get; set; }

        [JsonProperty("innerHtml")]
        public string InnerHtml { get; set; }

        [JsonProperty("innerText")]
        public string InnerText { get; set; }

        [JsonProperty("attributes")]
        public JToken Attributes { get; set; }

        [JsonProperty("isSelfClosing")]
        public bool IsSelfClosing { get; set; }
    }

    public class SelectElementsBodyInput
    {
        public SelectElementsBodyInput(string html, string selector)
        {
            this.Html = html;
            this.Selector = selector;
        }

        [JsonProperty("operation", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string Operation { get; set; } = "select";

        [JsonProperty("html", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Html { get; set; }

        [JsonProperty("selector", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Selector { get; set; }

        [JsonProperty("selector_type", DefaultValueHandling = DefaultValueHandling.Include)]
        public BodyInputSelectorTypeType? SelectorType { get; set; } = global::Microsoft.Azure.Workflows.Sdk.Connectors.Minisouphtmlparser.BodyInputSelectorTypeType.Css;
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum BodyInputSelectorTypeType
    {
        [EnumMember(Value = "css")]
        Css,
        [EnumMember(Value = "xpath")]
        Xpath
    }

    public class ExtractValuesResponse
    {
        [JsonProperty("success")]
        public bool Success { get; set; }

        [JsonProperty("values")]
        public string[] Values { get; set; }

        [JsonProperty("count")]
        public int Count { get; set; }
    }

    public class ExtractValuesBodyInput
    {
        public ExtractValuesBodyInput(string html, string selector, string attribute)
        {
            this.Html = html;
            this.Selector = selector;
            this.Attribute = attribute;
        }

        [JsonProperty("operation", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string Operation { get; set; } = "extract";

        [JsonProperty("html", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Html { get; set; }

        [JsonProperty("selector", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Selector { get; set; }

        [JsonProperty("attribute", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Attribute { get; set; }

        [JsonProperty("selector_type", DefaultValueHandling = DefaultValueHandling.Include)]
        public BodyInputSelectorTypeType? SelectorType { get; set; } = global::Microsoft.Azure.Workflows.Sdk.Connectors.Minisouphtmlparser.BodyInputSelectorTypeType.Css;
    }

    public class FindAllElementsResponse
    {
        [JsonProperty("success")]
        public bool Success { get; set; }

        [JsonProperty("elements")]
        public HtmlElement[] Elements { get; set; }

        [JsonProperty("count")]
        public int Count { get; set; }
    }

    public class FindAllElementsBodyInput
    {
        public FindAllElementsBodyInput(string html, string tagName)
        {
            this.Html = html;
            this.TagName = tagName;
        }

        [JsonProperty("operation", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string Operation { get; set; } = "find_all";

        [JsonProperty("html", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Html { get; set; }

        [JsonProperty("tag_name", DefaultValueHandling = DefaultValueHandling.Include)]
        public string TagName { get; set; }

        [JsonProperty("attributes")]
        public BodyInputAttributesType Attributes { get; set; }
    }

    public class BodyInputAttributesType
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("class")]
        public string Class { get; set; }
    }

    public class ParseTableResponse
    {
        [JsonProperty("success")]
        public bool Success { get; set; }

        [JsonProperty("data")]
        public ParseTableResponseDataType Data { get; set; }
    }

    public class ParseTableResponseDataType
    {
        public string[] Headers { get; set; }
        public string[][] Rows { get; set; }
    }

    public class ParseTableBodyInput
    {
        public ParseTableBodyInput(string html)
        {
            this.Html = html;
        }

        [JsonProperty("operation", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string Operation { get; set; } = "parse_table";

        [JsonProperty("html", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Html { get; set; }

        [JsonProperty("table_selector", DefaultValueHandling = DefaultValueHandling.Include)]
        public string TableSelector { get; set; } = "table";

        [JsonProperty("header_rows_exist", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? HeaderRowsExist { get; set; } = true;
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Minisouphtmlparser;

    public partial class WorkflowManagedActions
    {
        public MinisouphtmlparserActions Minisouphtmlparser(string connectionId) => new MinisouphtmlparserActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public MinisouphtmlparserTriggers Minisouphtmlparser(string connectionId) => new MinisouphtmlparserTriggers(connectionId);
    }
}