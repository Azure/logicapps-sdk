//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Minisouphtmlparser
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class MinisouphtmlparserActions([ConnectionName] string connectionId)
    {

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "minisouphtmlparser")]
        [WorkflowExpressionFactory(nameof(__BuildFetchHTML))]
        public IBodyWorkflowAction<FetchHTMLResponse> FetchHTML([WorkflowExpression] Func<string> bodyurl)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<FetchHTMLResponse> __BuildFetchHTML(WorkflowExpression<string> bodyurl)
        {
            WorkflowExpression.Validate(bodyurl, nameof(bodyurl), required: true);
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
                body["url"] = ExpressionConverter.ConvertO(bodyurl);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<FetchHTMLResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "minisouphtmlparser")]
        [WorkflowExpressionFactory(nameof(__BuildSelectElements))]
        public IBodyWorkflowAction<SelectElementsResponse> SelectElements([WorkflowExpression] Func<string> bodyhtml, [WorkflowExpression] Func<string> bodyselector, [WorkflowExpression] Func<bodyselectorTypeInput> bodyselectorType = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<SelectElementsResponse> __BuildSelectElements(WorkflowExpression<string> bodyhtml, WorkflowExpression<string> bodyselector, WorkflowExpression<bodyselectorTypeInput> bodyselectorType = null)
        {
            WorkflowExpression.Validate(bodyhtml, nameof(bodyhtml), required: true);
            WorkflowExpression.Validate(bodyselector, nameof(bodyselector), required: true);
            WorkflowExpression.Validate(bodyselectorType, nameof(bodyselectorType), required: false);
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
                body["html"] = ExpressionConverter.ConvertO(bodyhtml);
                bodypropCount++;
                body["selector"] = ExpressionConverter.ConvertO(bodyselector);
                if (bodyselectorType != null)
                {
                    if (bodyselectorType != null)
                    {
                        body["selector_type"] = ExpressionConverter.ConvertO(bodyselectorType);
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
        [WorkflowExpressionFactory(nameof(__BuildExtractValues))]
        public IBodyWorkflowAction<ExtractValuesResponse> ExtractValues([WorkflowExpression] Func<string> bodyhtml, [WorkflowExpression] Func<string> bodyselector, [WorkflowExpression] Func<string> bodyattribute, [WorkflowExpression] Func<bodyselectorTypeInput> bodyselectorType = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ExtractValuesResponse> __BuildExtractValues(WorkflowExpression<string> bodyhtml, WorkflowExpression<string> bodyselector, WorkflowExpression<string> bodyattribute, WorkflowExpression<bodyselectorTypeInput> bodyselectorType = null)
        {
            WorkflowExpression.Validate(bodyhtml, nameof(bodyhtml), required: true);
            WorkflowExpression.Validate(bodyselector, nameof(bodyselector), required: true);
            WorkflowExpression.Validate(bodyattribute, nameof(bodyattribute), required: true);
            WorkflowExpression.Validate(bodyselectorType, nameof(bodyselectorType), required: false);
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
                body["html"] = ExpressionConverter.ConvertO(bodyhtml);
                bodypropCount++;
                body["selector"] = ExpressionConverter.ConvertO(bodyselector);
                bodypropCount++;
                body["attribute"] = ExpressionConverter.ConvertO(bodyattribute);
                if (bodyselectorType != null)
                {
                    if (bodyselectorType != null)
                    {
                        body["selector_type"] = ExpressionConverter.ConvertO(bodyselectorType);
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
        [WorkflowExpressionFactory(nameof(__BuildFindAllElements))]
        public IBodyWorkflowAction<FindAllElementsResponse> FindAllElements([WorkflowExpression] Func<string> bodyhtml, [WorkflowExpression] Func<string> bodytagName, [WorkflowExpression] Func<string> bodyattributesid = null, [WorkflowExpression] Func<string> bodyattributesClass = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<FindAllElementsResponse> __BuildFindAllElements(WorkflowExpression<string> bodyhtml, WorkflowExpression<string> bodytagName, WorkflowExpression<string> bodyattributesid = null, WorkflowExpression<string> bodyattributesClass = null)
        {
            WorkflowExpression.Validate(bodyhtml, nameof(bodyhtml), required: true);
            WorkflowExpression.Validate(bodytagName, nameof(bodytagName), required: true);
            WorkflowExpression.Validate(bodyattributesid, nameof(bodyattributesid), required: false);
            WorkflowExpression.Validate(bodyattributesClass, nameof(bodyattributesClass), required: false);
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
                body["html"] = ExpressionConverter.ConvertO(bodyhtml);
                bodypropCount++;
                body["tag_name"] = ExpressionConverter.ConvertO(bodytagName);
                var attributesObject = new JObject();
                var attributesObjectpropCount = 0;
                if (bodyattributesid != null)
                {
                    attributesObject["id"] = ExpressionConverter.ConvertO(bodyattributesid);
                    attributesObjectpropCount++;
                }

                if (bodyattributesClass != null)
                {
                    attributesObject["class"] = ExpressionConverter.ConvertO(bodyattributesClass);
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
        [WorkflowExpressionFactory(nameof(__BuildParseTable))]
        public IBodyWorkflowAction<ParseTableResponse> ParseTable([WorkflowExpression] Func<string> bodyhtml, [WorkflowExpression] Func<string> bodytableSelector = null, [WorkflowExpression] Func<bool> bodyheaderRowsExist = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ParseTableResponse> __BuildParseTable(WorkflowExpression<string> bodyhtml, WorkflowExpression<string> bodytableSelector = null, WorkflowExpression<bool> bodyheaderRowsExist = null)
        {
            WorkflowExpression.Validate(bodyhtml, nameof(bodyhtml), required: true);
            WorkflowExpression.Validate(bodytableSelector, nameof(bodytableSelector), required: false);
            WorkflowExpression.Validate(bodyheaderRowsExist, nameof(bodyheaderRowsExist), required: false);
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
                body["html"] = ExpressionConverter.ConvertO(bodyhtml);
                if (bodytableSelector != null)
                {
                    if (bodytableSelector != null)
                    {
                        body["table_selector"] = ExpressionConverter.ConvertO(bodytableSelector);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["table_selector"] = "table";
                    bodypropCount++;
                }

                if (bodyheaderRowsExist != null)
                {
                    if (bodyheaderRowsExist != null)
                    {
                        body["header_rows_exist"] = ExpressionConverter.ConvertO(bodyheaderRowsExist);
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