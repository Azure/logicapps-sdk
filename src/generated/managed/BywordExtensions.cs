//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Byword
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class BywordActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "byword")]
        public IBodyWorkflowAction<ArticlePostResponse> Article([WorkflowExpression] Func<bodymodeInput> bodymode, [WorkflowExpression] Func<string> bodyinput, [WorkflowExpression] Func<string> bodylanguage = null, [WorkflowExpression] Func<string> bodysubheadings = null, [WorkflowExpression] Func<bool> bodyundetectable = null, [WorkflowExpression] Func<string> bodytone = null, [WorkflowExpression] Func<int> bodylength = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/create_article";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["mode"] = SourceExpressionConverter.Convert(bodymode);
                bodypropCount++;
                body["input"] = SourceExpressionConverter.ConvertToken(bodyinput);
                if (bodylanguage != null)
                {
                    body["language"] = SourceExpressionConverter.ConvertToken(bodylanguage);
                    bodypropCount++;
                }

                if (bodysubheadings != null)
                {
                    body["subheadings"] = SourceExpressionConverter.ConvertToken(bodysubheadings);
                    bodypropCount++;
                }

                if (bodyundetectable != null)
                {
                    body["undetectable"] = SourceExpressionConverter.ConvertToken(bodyundetectable);
                    bodypropCount++;
                }

                if (bodytone != null)
                {
                    body["tone"] = SourceExpressionConverter.ConvertToken(bodytone);
                    bodypropCount++;
                }

                if (bodylength != null)
                {
                    body["length"] = SourceExpressionConverter.ConvertToken(bodylength);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<ArticlePostResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "byword")]
        public IBodyWorkflowAction<ArticleGetPostResponse> ArticleGet([WorkflowExpression] Func<string> bodyarticleId = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/get_article";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyarticleId != null)
                {
                    body["articleID"] = SourceExpressionConverter.ConvertToken(bodyarticleId);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<ArticleGetPostResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "byword")]
        public IBodyWorkflowAction<ArticlesPostResponseItem[]> Articles([WorkflowExpression] Func<int> bodycursor = null)
        {
            ApiConnectionActionInput BuildSourceInput()
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
                        body["cursor"] = SourceExpressionConverter.ConvertToken(bodycursor);
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
                return callPayload;
            }

            return new ApiConnectionAction<ArticlesPostResponseItem[]>(BuildSourceInput);
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