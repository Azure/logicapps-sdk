//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------
namespace Microsoft.Azure.Workflows.Sdk.Connectors.Newsdataio
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class NewsdataioActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "newsdataio")]
        public IBodyWorkflowAction<LatestGetResponse> LatestGet(Expression<Func<string>> q = null, Expression<Func<string>> qInTitle = null, Expression<Func<string>> country = null, Expression<Func<string>> category = null, Expression<Func<string>> language = null, Expression<Func<string>> domain = null, Expression<Func<fullContentInput>> fullContent = null, Expression<Func<imageInput>> image = null, Expression<Func<videoInput>> video = null, Expression<Func<string>> page = null)
        {
            var __workflow_q = WorkflowExpression.Compile(q, nameof(q), required: false);
            var __workflow_qInTitle = WorkflowExpression.Compile(qInTitle, nameof(qInTitle), required: false);
            var __workflow_country = WorkflowExpression.Compile(country, nameof(country), required: false);
            var __workflow_category = WorkflowExpression.Compile(category, nameof(category), required: false);
            var __workflow_language = WorkflowExpression.Compile(language, nameof(language), required: false);
            var __workflow_domain = WorkflowExpression.Compile(domain, nameof(domain), required: false);
            var __workflow_fullContent = WorkflowExpression.Compile(fullContent, nameof(fullContent), required: false);
            var __workflow_image = WorkflowExpression.Compile(image, nameof(image), required: false);
            var __workflow_video = WorkflowExpression.Compile(video, nameof(video), required: false);
            var __workflow_page = WorkflowExpression.Compile(page, nameof(page), required: false);
            return new DeferredBodyAction<LatestGetResponse>(() =>
            {
                var apiCallPath = "/news";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_q != null)
                    callPayload.Queries["q"] = ExpressionConverter.Convert(__workflow_q);
                if (__workflow_qInTitle != null)
                    callPayload.Queries["qInTitle"] = ExpressionConverter.Convert(__workflow_qInTitle);
                if (__workflow_country != null)
                    callPayload.Queries["country"] = ExpressionConverter.Convert(__workflow_country);
                if (__workflow_category != null)
                    callPayload.Queries["category"] = ExpressionConverter.Convert(__workflow_category);
                if (__workflow_language != null)
                    callPayload.Queries["language"] = ExpressionConverter.Convert(__workflow_language);
                if (__workflow_domain != null)
                    callPayload.Queries["domain"] = ExpressionConverter.Convert(__workflow_domain);
                if (__workflow_fullContent != null)
                    callPayload.Queries["full_content"] = ExpressionConverter.Convert(__workflow_fullContent);
                if (__workflow_image != null)
                    callPayload.Queries["image"] = ExpressionConverter.Convert(__workflow_image);
                if (__workflow_video != null)
                    callPayload.Queries["video"] = ExpressionConverter.Convert(__workflow_video);
                if (__workflow_page != null)
                    callPayload.Queries["page"] = ExpressionConverter.Convert(__workflow_page);
                return new ApiConnectionAction<LatestGetResponse>(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }
    }

    public class NewsdataioTriggers([ConnectionName] string connectionId)
    {
    }

    public class LatestGetResponse
    {
        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("totalResults")]
        public int TotalResults { get; set; }

        [JsonProperty("results")]
        public LatestGetResponseResultsTypeItem[] Results { get; set; }

        [JsonProperty("nextPage")]
        public string NextPage { get; set; }
    }

    public class LatestGetResponseResultsTypeItem
    {
        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("link")]
        public string Link { get; set; }

        [JsonProperty("keywords")]
        public string[] Keywords { get; set; }

        [JsonProperty("creator")]
        public string[] Creator { get; set; }

        [JsonProperty("video_url")]
        public string VideoUrl { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("content")]
        public string Content { get; set; }

        [JsonProperty("pubDate")]
        public string PubDate { get; set; }

        [JsonProperty("image_url")]
        public string ImageUrl { get; set; }

        [JsonProperty("source_id")]
        public string SourceId { get; set; }

        [JsonProperty("category")]
        public string[] Category { get; set; }

        [JsonProperty("country")]
        public string[] Country { get; set; }

        [JsonProperty("language")]
        public string Language { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum fullContentInput
    {
        [EnumMember(Value = "0")]
        _0,
        [EnumMember(Value = "1")]
        _1
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum imageInput
    {
        [EnumMember(Value = "0")]
        _0,
        [EnumMember(Value = "1")]
        _1
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum videoInput
    {
        [EnumMember(Value = "0")]
        _0,
        [EnumMember(Value = "1")]
        _1
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Newsdataio;

    public partial class WorkflowManagedActions
    {
        public NewsdataioActions Newsdataio(string connectionId) => new NewsdataioActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public NewsdataioTriggers Newsdataio(string connectionId) => new NewsdataioTriggers(connectionId);
    }
}
