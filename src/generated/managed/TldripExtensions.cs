//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Tldrip
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class TldripActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tldrip")]
        public IBodyWorkflowAction<ArticleHumanPostResponse> ArticleHuman([WorkflowExpression] Func<string> bodyurl, [WorkflowExpression] Func<int> bodyminLength = null, [WorkflowExpression] Func<int> bodymaxLength = null, [WorkflowExpression] Func<bool> bodyisDetailed = null)
        {
            SourceExpression.Validate(bodyurl, nameof(bodyurl), required: true);
            SourceExpression.Validate(bodyminLength, nameof(bodyminLength), required: false);
            SourceExpression.Validate(bodymaxLength, nameof(bodymaxLength), required: false);
            SourceExpression.Validate(bodyisDetailed, nameof(bodyisDetailed), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/model/abstractive/summarize-url/";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["url"] = SourceExpressionConverter.ConvertToken(bodyurl);
                if (bodyminLength != null)
                {
                    if (bodyminLength != null)
                    {
                        body["min_length"] = SourceExpressionConverter.ConvertToken(bodyminLength);
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
                        body["max_length"] = SourceExpressionConverter.ConvertToken(bodymaxLength);
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
                    body["is_detailed"] = SourceExpressionConverter.ConvertToken(bodyisDetailed);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<ArticleHumanPostResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tldrip")]
        public IBodyWorkflowAction<ExtractArticlePostResponse> ExtractArticle([WorkflowExpression] Func<string> bodyurl, [WorkflowExpression] Func<int> bodynumSentences = null, [WorkflowExpression] Func<bool> bodyisDetailed = null)
        {
            SourceExpression.Validate(bodyurl, nameof(bodyurl), required: true);
            SourceExpression.Validate(bodynumSentences, nameof(bodynumSentences), required: false);
            SourceExpression.Validate(bodyisDetailed, nameof(bodyisDetailed), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/model/extractive/summarize-url/";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["url"] = SourceExpressionConverter.ConvertToken(bodyurl);
                if (bodynumSentences != null)
                {
                    body["num_sentences"] = SourceExpressionConverter.ConvertToken(bodynumSentences);
                    bodypropCount++;
                }

                if (bodyisDetailed != null)
                {
                    if (bodyisDetailed != null)
                    {
                        body["is_detailed"] = SourceExpressionConverter.ConvertToken(bodyisDetailed);
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
                return callPayload;
            }

            return new ApiConnectionAction<ExtractArticlePostResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tldrip")]
        public IBodyWorkflowAction<TextHumanPostResponse> TextHuman([WorkflowExpression] Func<string> bodytext, [WorkflowExpression] Func<int> bodyminLength = null, [WorkflowExpression] Func<int> bodymaxLength = null)
        {
            SourceExpression.Validate(bodytext, nameof(bodytext), required: true);
            SourceExpression.Validate(bodyminLength, nameof(bodyminLength), required: false);
            SourceExpression.Validate(bodymaxLength, nameof(bodymaxLength), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/model/abstractive/summarize-text/";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["text"] = SourceExpressionConverter.ConvertToken(bodytext);
                if (bodyminLength != null)
                {
                    if (bodyminLength != null)
                    {
                        body["min_length"] = SourceExpressionConverter.ConvertToken(bodyminLength);
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
                        body["max_length"] = SourceExpressionConverter.ConvertToken(bodymaxLength);
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
                return callPayload;
            }

            return new ApiConnectionAction<TextHumanPostResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tldrip")]
        public IBodyWorkflowAction<ExtractTextPostResponse> ExtractText([WorkflowExpression] Func<string> bodytext, [WorkflowExpression] Func<int> bodynumSentences = null)
        {
            SourceExpression.Validate(bodytext, nameof(bodytext), required: true);
            SourceExpression.Validate(bodynumSentences, nameof(bodynumSentences), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/model/extractive/summarize-text/";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["text"] = SourceExpressionConverter.ConvertToken(bodytext);
                if (bodynumSentences != null)
                {
                    body["num_sentences"] = SourceExpressionConverter.ConvertToken(bodynumSentences);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<ExtractTextPostResponse>(BuildSourceInput);
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