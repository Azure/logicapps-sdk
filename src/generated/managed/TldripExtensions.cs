//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Tldrip
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class TldripActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tldrip")]
        public IBodyWorkflowAction<ArticleHumanPostResponse> ArticleHumanPost(Expression<Func<string>> bodyurl, Expression<Func<int>> bodyminLength = null, Expression<Func<int>> bodymaxLength = null, Expression<Func<bool>> bodyisDetailed = null)
        {
            var apiCallPath = "/model/abstractive/summarize-url/";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["url"] = ExpressionConverter.ConvertO(bodyurl);
            if (bodyminLength != null)
            {
                body["min_length"] = ExpressionConverter.ConvertO(bodyminLength);
                bodypropCount++;
            }

            if (bodymaxLength != null)
            {
                body["max_length"] = ExpressionConverter.ConvertO(bodymaxLength);
                bodypropCount++;
            }

            if (bodyisDetailed != null)
            {
                body["is_detailed"] = ExpressionConverter.ConvertO(bodyisDetailed);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<ArticleHumanPostResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tldrip")]
        public IBodyWorkflowAction<ExtractArticlePostResponse> ExtractArticlePost(Expression<Func<string>> bodyurl, Expression<Func<int>> bodynumSentences = null, Expression<Func<bool>> bodyisDetailed = null)
        {
            var apiCallPath = "/model/extractive/summarize-url/";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["url"] = ExpressionConverter.ConvertO(bodyurl);
            if (bodynumSentences != null)
            {
                body["num_sentences"] = ExpressionConverter.ConvertO(bodynumSentences);
                bodypropCount++;
            }

            if (bodyisDetailed != null)
            {
                body["is_detailed"] = ExpressionConverter.ConvertO(bodyisDetailed);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<ExtractArticlePostResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tldrip")]
        public IBodyWorkflowAction<TextHumanPostResponse> TextHumanPost(Expression<Func<string>> bodytext, Expression<Func<int>> bodyminLength = null, Expression<Func<int>> bodymaxLength = null)
        {
            var apiCallPath = "/model/abstractive/summarize-text/";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["text"] = ExpressionConverter.ConvertO(bodytext);
            if (bodyminLength != null)
            {
                body["min_length"] = ExpressionConverter.ConvertO(bodyminLength);
                bodypropCount++;
            }

            if (bodymaxLength != null)
            {
                body["max_length"] = ExpressionConverter.ConvertO(bodymaxLength);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<TextHumanPostResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tldrip")]
        public IBodyWorkflowAction<ExtractTextPostResponse> ExtractTextPost(Expression<Func<string>> bodytext, Expression<Func<int>> bodynumSentences = null)
        {
            var apiCallPath = "/model/extractive/summarize-text/";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["text"] = ExpressionConverter.ConvertO(bodytext);
            if (bodynumSentences != null)
            {
                body["num_sentences"] = ExpressionConverter.ConvertO(bodynumSentences);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<ExtractTextPostResponse>(callPayload);
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

    public class TextHumanPostResponse
    {
        [JsonProperty("summary")]
        public string Summary { get; set; }
    }

    public class ExtractTextPostResponse
    {
        [JsonProperty("summary")]
        public string[] Summary { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Tldrip;

    public partial class WorkflowManagedActions
    {
        public TldripActions Tldrip(string connectionId) => new TldripActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public TldripTriggers Tldrip(string connectionId) => new TldripTriggers(connectionId);
    }
}