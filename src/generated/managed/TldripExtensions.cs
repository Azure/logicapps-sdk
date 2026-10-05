//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Tldrip
{
        using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class TldripActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tldrip")]
        [WorkflowExpressionFactory(nameof(__BuildArticleHuman))]
        public IBodyWorkflowAction<ArticleHumanPostResponse> ArticleHuman([WorkflowExpression] Func<string> bodyurl, [WorkflowExpression] Func<int> bodyminLength = null, [WorkflowExpression] Func<int> bodymaxLength = null, [WorkflowExpression] Func<bool> bodyisDetailed = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ArticleHumanPostResponse> __BuildArticleHuman(WorkflowValue<string> bodyurl, WorkflowValue<int> bodyminLength = null, WorkflowValue<int> bodymaxLength = null, WorkflowValue<bool> bodyisDetailed = null)
        {
            WorkflowValue.Validate(bodyurl, nameof(bodyurl), required: true);
            WorkflowValue.Validate(bodyminLength, nameof(bodyminLength), required: false);
            WorkflowValue.Validate(bodymaxLength, nameof(bodymaxLength), required: false);
            WorkflowValue.Validate(bodyisDetailed, nameof(bodyisDetailed), required: false);
            return new DeferredBodyAction<ArticleHumanPostResponse>(() =>
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
                    if (bodyminLength != null)
                    {
                        body["min_length"] = ExpressionConverter.ConvertO(bodyminLength);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["min_length"] = 100;
                    bodypropCount++;
                }

                if (bodymaxLength != null)
                {
                    if (bodymaxLength != null)
                    {
                        body["max_length"] = ExpressionConverter.ConvertO(bodymaxLength);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["max_length"] = 300;
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tldrip")]
        [WorkflowExpressionFactory(nameof(__BuildExtractArticle))]
        public IBodyWorkflowAction<ExtractArticlePostResponse> ExtractArticle([WorkflowExpression] Func<string> bodyurl, [WorkflowExpression] Func<int> bodynumSentences = null, [WorkflowExpression] Func<bool> bodyisDetailed = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ExtractArticlePostResponse> __BuildExtractArticle(WorkflowValue<string> bodyurl, WorkflowValue<int> bodynumSentences = null, WorkflowValue<bool> bodyisDetailed = null)
        {
            WorkflowValue.Validate(bodyurl, nameof(bodyurl), required: true);
            WorkflowValue.Validate(bodynumSentences, nameof(bodynumSentences), required: false);
            WorkflowValue.Validate(bodyisDetailed, nameof(bodyisDetailed), required: false);
            return new DeferredBodyAction<ExtractArticlePostResponse>(() =>
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
                    if (bodyisDetailed != null)
                    {
                        body["is_detailed"] = ExpressionConverter.ConvertO(bodyisDetailed);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["is_detailed"] = true;
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<ExtractArticlePostResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tldrip")]
        [WorkflowExpressionFactory(nameof(__BuildTextHuman))]
        public IBodyWorkflowAction<TextHumanPostResponse> TextHuman([WorkflowExpression] Func<string> bodytext, [WorkflowExpression] Func<int> bodyminLength = null, [WorkflowExpression] Func<int> bodymaxLength = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<TextHumanPostResponse> __BuildTextHuman(WorkflowValue<string> bodytext, WorkflowValue<int> bodyminLength = null, WorkflowValue<int> bodymaxLength = null)
        {
            WorkflowValue.Validate(bodytext, nameof(bodytext), required: true);
            WorkflowValue.Validate(bodyminLength, nameof(bodyminLength), required: false);
            WorkflowValue.Validate(bodymaxLength, nameof(bodymaxLength), required: false);
            return new DeferredBodyAction<TextHumanPostResponse>(() =>
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
                    if (bodyminLength != null)
                    {
                        body["min_length"] = ExpressionConverter.ConvertO(bodyminLength);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["min_length"] = 100;
                    bodypropCount++;
                }

                if (bodymaxLength != null)
                {
                    if (bodymaxLength != null)
                    {
                        body["max_length"] = ExpressionConverter.ConvertO(bodymaxLength);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["max_length"] = 300;
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<TextHumanPostResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tldrip")]
        [WorkflowExpressionFactory(nameof(__BuildExtractText))]
        public IBodyWorkflowAction<ExtractTextPostResponse> ExtractText([WorkflowExpression] Func<string> bodytext, [WorkflowExpression] Func<int> bodynumSentences = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ExtractTextPostResponse> __BuildExtractText(WorkflowValue<string> bodytext, WorkflowValue<int> bodynumSentences = null)
        {
            WorkflowValue.Validate(bodytext, nameof(bodytext), required: true);
            WorkflowValue.Validate(bodynumSentences, nameof(bodynumSentences), required: false);
            return new DeferredBodyAction<ExtractTextPostResponse>(() =>
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
