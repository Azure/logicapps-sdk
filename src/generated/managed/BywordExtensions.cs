//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Byword
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class BywordActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "byword")]
        public IBodyWorkflowAction<ArticlePostResponse, ApiConnectionActionConfiguration> Article(Expression<Func<bodymodeInput>> bodymode, Expression<Func<string>> bodyinput, Expression<Func<string>> bodylanguage = null, Expression<Func<string>> bodysubheadings = null, Expression<Func<bool>> bodyundetectable = null, Expression<Func<string>> bodytone = null, Expression<Func<int>> bodylength = null)
        {
            var __workflow_bodymode = WorkflowExpression.Compile(bodymode, nameof(bodymode), required: true);
            var __workflow_bodyinput = WorkflowExpression.Compile(bodyinput, nameof(bodyinput), required: true);
            var __workflow_bodylanguage = WorkflowExpression.Compile(bodylanguage, nameof(bodylanguage), required: false);
            var __workflow_bodysubheadings = WorkflowExpression.Compile(bodysubheadings, nameof(bodysubheadings), required: false);
            var __workflow_bodyundetectable = WorkflowExpression.Compile(bodyundetectable, nameof(bodyundetectable), required: false);
            var __workflow_bodytone = WorkflowExpression.Compile(bodytone, nameof(bodytone), required: false);
            var __workflow_bodylength = WorkflowExpression.Compile(bodylength, nameof(bodylength), required: false);
            return new DeferredBodyAction<ArticlePostResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/create_article";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["mode"] = ExpressionConverter.ConvertO(__workflow_bodymode);
                bodypropCount++;
                body["input"] = ExpressionConverter.ConvertO(__workflow_bodyinput);
                if (__workflow_bodylanguage != null)
                {
                    body["language"] = ExpressionConverter.ConvertO(__workflow_bodylanguage);
                    bodypropCount++;
                }

                if (__workflow_bodysubheadings != null)
                {
                    body["subheadings"] = ExpressionConverter.ConvertO(__workflow_bodysubheadings);
                    bodypropCount++;
                }

                if (__workflow_bodyundetectable != null)
                {
                    body["undetectable"] = ExpressionConverter.ConvertO(__workflow_bodyundetectable);
                    bodypropCount++;
                }

                if (__workflow_bodytone != null)
                {
                    body["tone"] = ExpressionConverter.ConvertO(__workflow_bodytone);
                    bodypropCount++;
                }

                if (__workflow_bodylength != null)
                {
                    body["length"] = ExpressionConverter.ConvertO(__workflow_bodylength);
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
        public IBodyWorkflowAction<ArticleGetPostResponse, ApiConnectionActionConfiguration> ArticleGet(Expression<Func<string>> bodyarticleId = null)
        {
            var __workflow_bodyarticleId = WorkflowExpression.Compile(bodyarticleId, nameof(bodyarticleId), required: false);
            return new DeferredBodyAction<ArticleGetPostResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/get_article";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodyarticleId != null)
                {
                    body["articleID"] = ExpressionConverter.ConvertO(__workflow_bodyarticleId);
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
        public IBodyWorkflowAction<ArticlesPostResponseItem[], ApiConnectionActionConfiguration> Articles(Expression<Func<int>> bodycursor = null)
        {
            var __workflow_bodycursor = WorkflowExpression.Compile(bodycursor, nameof(bodycursor), required: false);
            return new DeferredBodyAction<ArticlesPostResponseItem[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/list_articles";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodycursor != null)
                {
                    if (__workflow_bodycursor != null)
                    {
                        body["cursor"] = ExpressionConverter.ConvertO(__workflow_bodycursor);
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
        public string ArticleId { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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