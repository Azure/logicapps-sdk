//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Tldrip
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class TldripActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tldrip")]
        public IBodyWorkflowAction<ArticleHumanResponse, ApiConnectionActionConfiguration> ArticleHuman(Expression<Func<ArticleHumanBodyInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<ArticleHumanResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/model/abstractive/summarize-url/";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<ArticleHumanResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tldrip")]
        public IBodyWorkflowAction<ExtractArticleResponse, ApiConnectionActionConfiguration> ExtractArticle(Expression<Func<ExtractArticleBodyInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<ExtractArticleResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/model/extractive/summarize-url/";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<ExtractArticleResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tldrip")]
        public IBodyWorkflowAction<TextHumanResponse, ApiConnectionActionConfiguration> TextHuman(Expression<Func<TextHumanBodyInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<TextHumanResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/model/abstractive/summarize-text/";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<TextHumanResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tldrip")]
        public IBodyWorkflowAction<ExtractTextResponse, ApiConnectionActionConfiguration> ExtractText(Expression<Func<ExtractTextBodyInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<ExtractTextResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/model/extractive/summarize-text/";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<ExtractTextResponse>(callPayload);
            });
        }
    }

    public class TldripTriggers([ConnectionName] string connectionId)
    {
    }

    public class ArticleHumanResponse
    {
        [JsonProperty("summary")]
        public string[] Summary { get; set; }

        [JsonProperty("article_text")]
        public string ArticleText { get; set; }

        [JsonProperty("article_title")]
        public string ArticleTitle { get; set; }

        [JsonProperty("article_authors")]
        public string[] ArticleAuthors { get; set; }

        [JsonProperty("article_image")]
        public string ArticleImage { get; set; }

        [JsonProperty("article_pub_date")]
        public string ArticlePubDate { get; set; }

        [JsonProperty("article_url")]
        public string ArticleUrl { get; set; }

        [JsonProperty("article_html")]
        public string ArticleHtml { get; set; }

        [JsonProperty("article_abstract")]
        public string ArticleAbstract { get; set; }
    }

    public class ArticleHumanBodyInput
    {
        public ArticleHumanBodyInput(string url)
        {
            this.Url = url;
        }

        [JsonProperty("url", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Url { get; set; }

        [JsonProperty("min_length", DefaultValueHandling = DefaultValueHandling.Include)]
        public int? MinLength { get; set; } = 100;

        [JsonProperty("max_length", DefaultValueHandling = DefaultValueHandling.Include)]
        public int? MaxLength { get; set; } = 300;

        [JsonProperty("is_detailed")]
        public bool? IsDetailed { get; set; }
    }

    public class ExtractArticleResponse
    {
        [JsonProperty("summary")]
        public string[] Summary { get; set; }

        [JsonProperty("article_text")]
        public string ArticleText { get; set; }

        [JsonProperty("article_title")]
        public string ArticleTitle { get; set; }

        [JsonProperty("article_authors")]
        public string[] ArticleAuthors { get; set; }

        [JsonProperty("article_image")]
        public string ArticleImage { get; set; }

        [JsonProperty("article_pub_date")]
        public string ArticlePubDate { get; set; }

        [JsonProperty("article_url")]
        public string ArticleUrl { get; set; }

        [JsonProperty("article_html")]
        public string ArticleHtml { get; set; }

        [JsonProperty("article_abstract")]
        public string ArticleAbstract { get; set; }
    }

    public class ExtractArticleBodyInput
    {
        public ExtractArticleBodyInput(string url)
        {
            this.Url = url;
        }

        [JsonProperty("url", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Url { get; set; }

        [JsonProperty("num_sentences")]
        public int? NumSentences { get; set; }

        [JsonProperty("is_detailed", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? IsDetailed { get; set; } = true;
    }

    public class TextHumanResponse
    {
        [JsonProperty("summary")]
        public string Summary { get; set; }
    }

    public class TextHumanBodyInput
    {
        public TextHumanBodyInput(string text)
        {
            this.Text = text;
        }

        [JsonProperty("text", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Text { get; set; }

        [JsonProperty("min_length", DefaultValueHandling = DefaultValueHandling.Include)]
        public int? MinLength { get; set; } = 100;

        [JsonProperty("max_length", DefaultValueHandling = DefaultValueHandling.Include)]
        public int? MaxLength { get; set; } = 300;
    }

    public class ExtractTextResponse
    {
        [JsonProperty("summary")]
        public string[] Summary { get; set; }
    }

    public class ExtractTextBodyInput
    {
        public ExtractTextBodyInput(string text)
        {
            this.Text = text;
        }

        [JsonProperty("text", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Text { get; set; }

        [JsonProperty("num_sentences")]
        public int? NumSentences { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Tldrip;

    public partial class WorkflowManagedActions
    {
        public TldripActions Tldrip(string connectionId) => new TldripActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public TldripTriggers Tldrip(string connectionId) => new TldripTriggers(connectionId);
    }
}