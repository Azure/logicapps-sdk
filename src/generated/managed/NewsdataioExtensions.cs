//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Newsdataio
{
        using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class NewsdataioActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "newsdataio")]
        [WorkflowExpressionFactory(nameof(__BuildLatestGet))]
        public IBodyWorkflowAction<LatestGetResponse> LatestGet([WorkflowExpression] Func<string> q = null, [WorkflowExpression] Func<string> qInTitle = null, [WorkflowExpression] Func<string> country = null, [WorkflowExpression] Func<string> category = null, [WorkflowExpression] Func<string> language = null, [WorkflowExpression] Func<string> domain = null, [WorkflowExpression] Func<fullContentInput> fullContent = null, [WorkflowExpression] Func<imageInput> image = null, [WorkflowExpression] Func<videoInput> video = null, [WorkflowExpression] Func<string> page = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<LatestGetResponse> __BuildLatestGet(WorkflowValue<string> q = null, WorkflowValue<string> qInTitle = null, WorkflowValue<string> country = null, WorkflowValue<string> category = null, WorkflowValue<string> language = null, WorkflowValue<string> domain = null, WorkflowValue<fullContentInput> fullContent = null, WorkflowValue<imageInput> image = null, WorkflowValue<videoInput> video = null, WorkflowValue<string> page = null)
        {
            WorkflowValue.Validate(q, nameof(q), required: false);
            WorkflowValue.Validate(qInTitle, nameof(qInTitle), required: false);
            WorkflowValue.Validate(country, nameof(country), required: false);
            WorkflowValue.Validate(category, nameof(category), required: false);
            WorkflowValue.Validate(language, nameof(language), required: false);
            WorkflowValue.Validate(domain, nameof(domain), required: false);
            WorkflowValue.Validate(fullContent, nameof(fullContent), required: false);
            WorkflowValue.Validate(image, nameof(image), required: false);
            WorkflowValue.Validate(video, nameof(video), required: false);
            WorkflowValue.Validate(page, nameof(page), required: false);
            return new DeferredBodyAction<LatestGetResponse>(() =>
            {
                var apiCallPath = "/news";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (q != null)
                    callPayload.Queries["q"] = ExpressionConverter.Convert(q);
                if (qInTitle != null)
                    callPayload.Queries["qInTitle"] = ExpressionConverter.Convert(qInTitle);
                if (country != null)
                    callPayload.Queries["country"] = ExpressionConverter.Convert(country);
                if (category != null)
                    callPayload.Queries["category"] = ExpressionConverter.Convert(category);
                if (language != null)
                    callPayload.Queries["language"] = ExpressionConverter.Convert(language);
                if (domain != null)
                    callPayload.Queries["domain"] = ExpressionConverter.Convert(domain);
                if (fullContent != null)
                    callPayload.Queries["full_content"] = ExpressionConverter.Convert(fullContent);
                if (image != null)
                    callPayload.Queries["image"] = ExpressionConverter.Convert(image);
                if (video != null)
                    callPayload.Queries["video"] = ExpressionConverter.Convert(video);
                if (page != null)
                    callPayload.Queries["page"] = ExpressionConverter.Convert(page);
                return new ApiConnectionAction<LatestGetResponse>(callPayload);
            });
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

    public enum fullContentInput
    {
        [EnumMember(Value = "0")]
        _0,
        [EnumMember(Value = "1")]
        _1
    }

    public enum imageInput
    {
        [EnumMember(Value = "0")]
        _0,
        [EnumMember(Value = "1")]
        _1
    }

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
