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
        public IBodyWorkflowAction<FetchHTMLResponse> FetchHTML(Expression<Func<string>> bodyurl)
        {
            var __workflow_bodyurl = WorkflowExpression.Compile(bodyurl, nameof(bodyurl), required: true);
            return new DeferredBodyAction<FetchHTMLResponse>(() =>
            {
                var apiCallPath = "/fetch-html";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                body["operation"] = "fetch_html";
                bodypropCount++;
                bodypropCount++;
                body["url"] = ExpressionConverter.ConvertO(__workflow_bodyurl);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<FetchHTMLResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "minisouphtmlparser")]
        public IBodyWorkflowAction<SelectElementsResponse> SelectElements(Expression<Func<string>> bodyhtml, Expression<Func<string>> bodyselector, Expression<Func<bodyselectorTypeInput>> bodyselectorType = null)
        {
            var __workflow_bodyhtml = WorkflowExpression.Compile(bodyhtml, nameof(bodyhtml), required: true);
            var __workflow_bodyselector = WorkflowExpression.Compile(bodyselector, nameof(bodyselector), required: true);
            var __workflow_bodyselectorType = WorkflowExpression.Compile(bodyselectorType, nameof(bodyselectorType), required: false);
            return new DeferredBodyAction<SelectElementsResponse>(() =>
            {
                var apiCallPath = "/select";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                body["operation"] = "select";
                bodypropCount++;
                bodypropCount++;
                body["html"] = ExpressionConverter.ConvertO(__workflow_bodyhtml);
                bodypropCount++;
                body["selector"] = ExpressionConverter.ConvertO(__workflow_bodyselector);
                if (__workflow_bodyselectorType != null)
                {
                    if (__workflow_bodyselectorType != null)
                    {
                        body["selector_type"] = ExpressionConverter.ConvertO(__workflow_bodyselectorType);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["selector_type"] = "css";
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<SelectElementsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "minisouphtmlparser")]
        public IBodyWorkflowAction<ExtractValuesResponse> ExtractValues(Expression<Func<string>> bodyhtml, Expression<Func<string>> bodyselector, Expression<Func<string>> bodyattribute, Expression<Func<bodyselectorTypeInput>> bodyselectorType = null)
        {
            var __workflow_bodyhtml = WorkflowExpression.Compile(bodyhtml, nameof(bodyhtml), required: true);
            var __workflow_bodyselector = WorkflowExpression.Compile(bodyselector, nameof(bodyselector), required: true);
            var __workflow_bodyattribute = WorkflowExpression.Compile(bodyattribute, nameof(bodyattribute), required: true);
            var __workflow_bodyselectorType = WorkflowExpression.Compile(bodyselectorType, nameof(bodyselectorType), required: false);
            return new DeferredBodyAction<ExtractValuesResponse>(() =>
            {
                var apiCallPath = "/extract";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                body["operation"] = "extract";
                bodypropCount++;
                bodypropCount++;
                body["html"] = ExpressionConverter.ConvertO(__workflow_bodyhtml);
                bodypropCount++;
                body["selector"] = ExpressionConverter.ConvertO(__workflow_bodyselector);
                bodypropCount++;
                body["attribute"] = ExpressionConverter.ConvertO(__workflow_bodyattribute);
                if (__workflow_bodyselectorType != null)
                {
                    if (__workflow_bodyselectorType != null)
                    {
                        body["selector_type"] = ExpressionConverter.ConvertO(__workflow_bodyselectorType);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["selector_type"] = "css";
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<ExtractValuesResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "minisouphtmlparser")]
        public IBodyWorkflowAction<FindAllElementsResponse> FindAllElements(Expression<Func<string>> bodyhtml, Expression<Func<string>> bodytagName, Expression<Func<string>> bodyattributesid = null, Expression<Func<string>> bodyattributesClass = null)
        {
            var __workflow_bodyhtml = WorkflowExpression.Compile(bodyhtml, nameof(bodyhtml), required: true);
            var __workflow_bodytagName = WorkflowExpression.Compile(bodytagName, nameof(bodytagName), required: true);
            var __workflow_bodyattributesid = WorkflowExpression.Compile(bodyattributesid, nameof(bodyattributesid), required: false);
            var __workflow_bodyattributesClass = WorkflowExpression.Compile(bodyattributesClass, nameof(bodyattributesClass), required: false);
            return new DeferredBodyAction<FindAllElementsResponse>(() =>
            {
                var apiCallPath = "/find-all";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                body["operation"] = "find_all";
                bodypropCount++;
                bodypropCount++;
                body["html"] = ExpressionConverter.ConvertO(__workflow_bodyhtml);
                bodypropCount++;
                body["tag_name"] = ExpressionConverter.ConvertO(__workflow_bodytagName);
                var attributesObject = new JObject();
                var attributesObjectpropCount = 0;
                if (__workflow_bodyattributesid != null)
                {
                    attributesObject["id"] = ExpressionConverter.ConvertO(__workflow_bodyattributesid);
                    attributesObjectpropCount++;
                }

                if (__workflow_bodyattributesClass != null)
                {
                    attributesObject["class"] = ExpressionConverter.ConvertO(__workflow_bodyattributesClass);
                    attributesObjectpropCount++;
                }

                if (attributesObjectpropCount > 0)
                {
                    body["attributes"] = attributesObject;
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<FindAllElementsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "minisouphtmlparser")]
        public IBodyWorkflowAction<ParseTableResponse> ParseTable(Expression<Func<string>> bodyhtml, Expression<Func<string>> bodytableSelector = null, Expression<Func<bool>> bodyheaderRowsExist = null)
        {
            var __workflow_bodyhtml = WorkflowExpression.Compile(bodyhtml, nameof(bodyhtml), required: true);
            var __workflow_bodytableSelector = WorkflowExpression.Compile(bodytableSelector, nameof(bodytableSelector), required: false);
            var __workflow_bodyheaderRowsExist = WorkflowExpression.Compile(bodyheaderRowsExist, nameof(bodyheaderRowsExist), required: false);
            return new DeferredBodyAction<ParseTableResponse>(() =>
            {
                var apiCallPath = "/parse-table";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                body["operation"] = "parse_table";
                bodypropCount++;
                bodypropCount++;
                body["html"] = ExpressionConverter.ConvertO(__workflow_bodyhtml);
                if (__workflow_bodytableSelector != null)
                {
                    if (__workflow_bodytableSelector != null)
                    {
                        body["table_selector"] = ExpressionConverter.ConvertO(__workflow_bodytableSelector);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["table_selector"] = "table";
                    bodypropCount++;
                }

                if (__workflow_bodyheaderRowsExist != null)
                {
                    if (__workflow_bodyheaderRowsExist != null)
                    {
                        body["header_rows_exist"] = ExpressionConverter.ConvertO(__workflow_bodyheaderRowsExist);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["header_rows_exist"] = true;
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum bodyselectorTypeInput
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

    public class FindAllElementsResponse
    {
        [JsonProperty("success")]
        public bool Success { get; set; }

        [JsonProperty("elements")]
        public HtmlElement[] Elements { get; set; }

        [JsonProperty("count")]
        public int Count { get; set; }
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
