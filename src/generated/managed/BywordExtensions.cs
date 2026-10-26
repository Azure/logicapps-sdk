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
        public IBodyWorkflowAction<ArticlePostResponse, ApiConnectionActionConfiguration> Article(Expression<Func<ArticlePostInput>> body = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<ArticlePostResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/create_article";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<ArticlePostResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "byword")]
        public IBodyWorkflowAction<ArticleGetPostResponse, ApiConnectionActionConfiguration> ArticleGet(Expression<Func<ArticleGetPostInput>> body = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<ArticleGetPostResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/get_article";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<ArticleGetPostResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "byword")]
        public IBodyWorkflowAction<ArticlesPostResponseItem[], ApiConnectionActionConfiguration> Articles(Expression<Func<ArticlesPostInput>> body = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<ArticlesPostResponseItem[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/list_articles";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
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

    public class ArticlePostInput
    {
        [JsonProperty("mode", DefaultValueHandling = DefaultValueHandling.Include)]
        public ArticlePostInputModeType Mode { get; set; } = ArticlePostInputModeType.Keyword;

        [JsonProperty("input", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Input { get; set; }

        [JsonProperty("language")]
        public string Language { get; set; }

        [JsonProperty("subheadings")]
        public string Subheadings { get; set; }

        [JsonProperty("undetectable")]
        public bool? Undetectable { get; set; }

        [JsonProperty("tone")]
        public string Tone { get; set; }

        [JsonProperty("length")]
        public int? Length { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum ArticlePostInputModeType
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

    public class ArticleGetPostInput
    {
        [JsonProperty("articleID")]
        public string ArticleId { get; set; }
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

    public class ArticlesPostInput
    {
        [JsonProperty("cursor", DefaultValueHandling = DefaultValueHandling.Include)]
        public int? Cursor { get; set; } = 0;
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