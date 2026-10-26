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
        public IBodyWorkflowAction<ArticleHumanPostResponse, ApiConnectionActionConfiguration> ArticleHuman(Expression<Func<ArticleHumanPostInput>> body = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<ArticleHumanPostResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/model/abstractive/summarize-url/";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<ArticleHumanPostResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tldrip")]
        public IBodyWorkflowAction<ExtractArticlePostResponse, ApiConnectionActionConfiguration> ExtractArticle(Expression<Func<ExtractArticlePostInput>> body = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<ExtractArticlePostResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/model/extractive/summarize-url/";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<ExtractArticlePostResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tldrip")]
        public IBodyWorkflowAction<TextHumanPostResponse, ApiConnectionActionConfiguration> TextHuman(Expression<Func<TextHumanPostInput>> body = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<TextHumanPostResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/model/abstractive/summarize-text/";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<TextHumanPostResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tldrip")]
        public IBodyWorkflowAction<ExtractTextPostResponse, ApiConnectionActionConfiguration> ExtractText(Expression<Func<ExtractTextPostInput>> body = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<ExtractTextPostResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/model/extractive/summarize-text/";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<ExtractTextPostResponse>(callPayload);
            });
        }
    }

    public class TldripTriggers([ConnectionName] string connectionId)
    {
    }

    public class ArticleHumanPostResponse
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

    public class ArticleHumanPostInput
    {
        [JsonProperty("url", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Url { get; set; }

        [JsonProperty("min_length", DefaultValueHandling = DefaultValueHandling.Include)]
        public int? MinLength { get; set; } = 100;

        [JsonProperty("max_length", DefaultValueHandling = DefaultValueHandling.Include)]
        public int? MaxLength { get; set; } = 300;

        [JsonProperty("is_detailed")]
        public bool? IsDetailed { get; set; }
    }

    public class ExtractArticlePostResponse
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

    public class ExtractArticlePostInput
    {
        [JsonProperty("url", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Url { get; set; }

        [JsonProperty("num_sentences")]
        public int? NumSentences { get; set; }

        [JsonProperty("is_detailed", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? IsDetailed { get; set; } = true;
    }

    public class TextHumanPostResponse
    {
        [JsonProperty("summary")]
        public string Summary { get; set; }
    }

    public class TextHumanPostInput
    {
        [JsonProperty("text", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Text { get; set; }

        [JsonProperty("min_length", DefaultValueHandling = DefaultValueHandling.Include)]
        public int? MinLength { get; set; } = 100;

        [JsonProperty("max_length", DefaultValueHandling = DefaultValueHandling.Include)]
        public int? MaxLength { get; set; } = 300;
    }

    public class ExtractTextPostResponse
    {
        [JsonProperty("summary")]
        public string[] Summary { get; set; }
    }

    public class ExtractTextPostInput
    {
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