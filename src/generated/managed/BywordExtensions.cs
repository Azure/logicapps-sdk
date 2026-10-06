//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Byword
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class BywordActions([ConnectionName] string connectionId)
    {

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "byword")]
        [WorkflowExpressionFactory(nameof(__BuildArticle))]
        public IBodyWorkflowAction<ArticlePostResponse> Article([WorkflowExpression] Func<bodymodeInput> bodymode, [WorkflowExpression] Func<string> bodyinput, [WorkflowExpression] Func<string> bodylanguage = null, [WorkflowExpression] Func<string> bodysubheadings = null, [WorkflowExpression] Func<bool> bodyundetectable = null, [WorkflowExpression] Func<string> bodytone = null, [WorkflowExpression] Func<int> bodylength = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "byword")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ArticlePostResponse> __BuildArticle(WorkflowExpression<bodymodeInput> bodymode, WorkflowExpression<string> bodyinput, WorkflowExpression<string> bodylanguage = null, WorkflowExpression<string> bodysubheadings = null, WorkflowExpression<bool> bodyundetectable = null, WorkflowExpression<string> bodytone = null, WorkflowExpression<int> bodylength = null)
        {
            WorkflowExpression.Validate(bodymode, nameof(bodymode), required: true);
            WorkflowExpression.Validate(bodyinput, nameof(bodyinput), required: true);
            WorkflowExpression.Validate(bodylanguage, nameof(bodylanguage), required: false);
            WorkflowExpression.Validate(bodysubheadings, nameof(bodysubheadings), required: false);
            WorkflowExpression.Validate(bodyundetectable, nameof(bodyundetectable), required: false);
            WorkflowExpression.Validate(bodytone, nameof(bodytone), required: false);
            WorkflowExpression.Validate(bodylength, nameof(bodylength), required: false);
            return new DeferredBodyAction<ArticlePostResponse>(() =>
            {
                var apiCallPath = "/create_article";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["mode"] = ExpressionConverter.ConvertO(bodymode);
                bodypropCount++;
                body["input"] = ExpressionConverter.ConvertO(bodyinput);
                if (bodylanguage != null)
                {
                    body["language"] = ExpressionConverter.ConvertO(bodylanguage);
                    bodypropCount++;
                }

                if (bodysubheadings != null)
                {
                    body["subheadings"] = ExpressionConverter.ConvertO(bodysubheadings);
                    bodypropCount++;
                }

                if (bodyundetectable != null)
                {
                    body["undetectable"] = ExpressionConverter.ConvertO(bodyundetectable);
                    bodypropCount++;
                }

                if (bodytone != null)
                {
                    body["tone"] = ExpressionConverter.ConvertO(bodytone);
                    bodypropCount++;
                }

                if (bodylength != null)
                {
                    body["length"] = ExpressionConverter.ConvertO(bodylength);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<ArticlePostResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "byword")]
        [WorkflowExpressionFactory(nameof(__BuildArticleGet))]
        public IBodyWorkflowAction<ArticleGetPostResponse> ArticleGet([WorkflowExpression] Func<string> bodyarticleID = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "byword")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ArticleGetPostResponse> __BuildArticleGet(WorkflowExpression<string> bodyarticleID = null)
        {
            WorkflowExpression.Validate(bodyarticleID, nameof(bodyarticleID), required: false);
            return new DeferredBodyAction<ArticleGetPostResponse>(() =>
            {
                var apiCallPath = "/get_article";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyarticleID != null)
                {
                    body["articleID"] = ExpressionConverter.ConvertO(bodyarticleID);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<ArticleGetPostResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "byword")]
        [WorkflowExpressionFactory(nameof(__BuildArticles))]
        public IBodyWorkflowAction<ArticlesPostResponseItem[]> Articles([WorkflowExpression] Func<int> bodycursor = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "byword")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ArticlesPostResponseItem[]> __BuildArticles(WorkflowExpression<int> bodycursor = null)
        {
            WorkflowExpression.Validate(bodycursor, nameof(bodycursor), required: false);
            return new DeferredBodyAction<ArticlesPostResponseItem[]>(() =>
            {
                var apiCallPath = "/list_articles";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodycursor != null)
                {
                    if (bodycursor != null)
                    {
                        body["cursor"] = ExpressionConverter.ConvertO(bodycursor);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["cursor"] = 0;
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<ArticlesPostResponseItem[]>(callPayload);
            });
        }
    }

    public class BywordTriggers([ConnectionName] string connectionId)
    {
    }

    public class ArticlePostResponse
    {
        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("articleID")]
        public string ArticleID { get; set; }
    }

    public enum bodymodeInput
    {
        [EnumMember(Value = "keyword")]
        Keyword,
        [EnumMember(Value = "title")]
        Title
    }

    public class ArticleGetPostResponse
    {
        public string Body { get; set; }

        [JsonProperty("Body (Markdown)")]
        public string BodyMarkdown { get; set; }

        [JsonProperty("Body (Plaintext)")]
        public string BodyPlaintext { get; set; }

        [JsonProperty("Created Date")]
        public string CreatedDate { get; set; }
        public string[] Headings { get; set; }

        [JsonProperty("Image - Assets")]
        public string[] ImageAssets { get; set; }
        public string Language { get; set; }
        public string Meta { get; set; }
        public string Mode { get; set; }
        public string Source { get; set; }
        public string Status { get; set; }

        [JsonProperty("Table of Contents")]
        public string TableOfContents { get; set; }
        public string Title { get; set; }

        [JsonProperty("URL Slug")]
        public string URLSlug { get; set; }

        [JsonProperty("_id")]
        public string Id { get; set; }
    }

    public class ArticlesPostResponseItem
    {
        public string Body { get; set; }

        [JsonProperty("Body (Markdown)")]
        public string BodyMarkdown { get; set; }

        [JsonProperty("Body (Plaintext)")]
        public string BodyPlaintext { get; set; }

        [JsonProperty("Created Date")]
        public string CreatedDate { get; set; }
        public string[] Headings { get; set; }

        [JsonProperty("Image - Assets")]
        public string[] ImageAssets { get; set; }
        public string Language { get; set; }
        public string Meta { get; set; }
        public string Mode { get; set; }
        public string Source { get; set; }
        public string Status { get; set; }

        [JsonProperty("Table of Contents")]
        public string TableOfContents { get; set; }
        public string Title { get; set; }

        [JsonProperty("URL Slug")]
        public string URLSlug { get; set; }

        [JsonProperty("_id")]
        public string Id { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Byword;

    public partial class WorkflowManagedActions
    {
        public BywordActions Byword(string connectionId) => new BywordActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public BywordTriggers Byword(string connectionId) => new BywordTriggers(connectionId);
    }
}