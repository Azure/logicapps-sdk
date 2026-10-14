//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------
namespace Microsoft.Azure.Workflows.Sdk.Connectors.Byword
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;
    using System.Linq.Expressions;

    public class BywordActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "byword")]
        public IBodyWorkflowAction<ArticlePostResponse> Article(Expression<Func<bodymodeInput>> bodymode, Expression<Func<string>> bodyinput, Expression<Func<string>> bodylanguage = null, Expression<Func<string>> bodysubheadings = null, Expression<Func<bool>> bodyundetectable = null, Expression<Func<string>> bodytone = null, Expression<Func<int>> bodylength = null)
        {
            var __workflow_bodymode = bodymode == null ? null : WorkflowExpression.Compile(bodymode);
            WorkflowExpression.Validate(__workflow_bodymode, nameof(bodymode), required: true);
            var __workflow_bodyinput = bodyinput == null ? null : WorkflowExpression.Compile(bodyinput);
            WorkflowExpression.Validate(__workflow_bodyinput, nameof(bodyinput), required: true);
            var __workflow_bodylanguage = bodylanguage == null ? null : WorkflowExpression.Compile(bodylanguage);
            WorkflowExpression.Validate(__workflow_bodylanguage, nameof(bodylanguage), required: false);
            var __workflow_bodysubheadings = bodysubheadings == null ? null : WorkflowExpression.Compile(bodysubheadings);
            WorkflowExpression.Validate(__workflow_bodysubheadings, nameof(bodysubheadings), required: false);
            var __workflow_bodyundetectable = bodyundetectable == null ? null : WorkflowExpression.Compile(bodyundetectable);
            WorkflowExpression.Validate(__workflow_bodyundetectable, nameof(bodyundetectable), required: false);
            var __workflow_bodytone = bodytone == null ? null : WorkflowExpression.Compile(bodytone);
            WorkflowExpression.Validate(__workflow_bodytone, nameof(bodytone), required: false);
            var __workflow_bodylength = bodylength == null ? null : WorkflowExpression.Compile(bodylength);
            WorkflowExpression.Validate(__workflow_bodylength, nameof(bodylength), required: false);
            return new DeferredBodyAction<ArticlePostResponse>(() =>
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
        public IBodyWorkflowAction<ArticleGetPostResponse> ArticleGet(Expression<Func<string>> bodyarticleID = null)
        {
            var __workflow_bodyarticleID = bodyarticleID == null ? null : WorkflowExpression.Compile(bodyarticleID);
            WorkflowExpression.Validate(__workflow_bodyarticleID, nameof(bodyarticleID), required: false);
            return new DeferredBodyAction<ArticleGetPostResponse>(() =>
            {
                var apiCallPath = "/get_article";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodyarticleID != null)
                {
                    body["articleID"] = ExpressionConverter.ConvertO(__workflow_bodyarticleID);
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
        public IBodyWorkflowAction<ArticlesPostResponseItem[]> Articles(Expression<Func<int>> bodycursor = null)
        {
            var __workflow_bodycursor = bodycursor == null ? null : WorkflowExpression.Compile(bodycursor);
            WorkflowExpression.Validate(__workflow_bodycursor, nameof(bodycursor), required: false);
            return new DeferredBodyAction<ArticlesPostResponseItem[]>(() =>
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
        public string ArticleID { get; set; }
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
