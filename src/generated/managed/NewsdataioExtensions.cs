//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Newsdataio
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class NewsdataioActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "newsdataio")]
        public IBodyWorkflowAction<LatestGetResponse> LatestGet([WorkflowExpression] Func<string> q = null, [WorkflowExpression] Func<string> qInTitle = null, [WorkflowExpression] Func<string> country = null, [WorkflowExpression] Func<string> category = null, [WorkflowExpression] Func<string> language = null, [WorkflowExpression] Func<string> domain = null, [WorkflowExpression] Func<fullContentInput> fullContent = null, [WorkflowExpression] Func<imageInput> image = null, [WorkflowExpression] Func<videoInput> video = null, [WorkflowExpression] Func<string> page = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/news";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (q != null)
                    callPayload.Queries["q"] = SourceExpressionConverter.ConvertO(q);
                if (qInTitle != null)
                    callPayload.Queries["qInTitle"] = SourceExpressionConverter.ConvertO(qInTitle);
                if (country != null)
                    callPayload.Queries["country"] = SourceExpressionConverter.ConvertO(country);
                if (category != null)
                    callPayload.Queries["category"] = SourceExpressionConverter.ConvertO(category);
                if (language != null)
                    callPayload.Queries["language"] = SourceExpressionConverter.ConvertO(language);
                if (domain != null)
                    callPayload.Queries["domain"] = SourceExpressionConverter.ConvertO(domain);
                if (fullContent != null)
                    callPayload.Queries["full_content"] = SourceExpressionConverter.Convert(fullContent);
                if (image != null)
                    callPayload.Queries["image"] = SourceExpressionConverter.Convert(image);
                if (video != null)
                    callPayload.Queries["video"] = SourceExpressionConverter.Convert(video);
                if (page != null)
                    callPayload.Queries["page"] = SourceExpressionConverter.ConvertO(page);
                return callPayload;
            }

            return new ApiConnectionAction<LatestGetResponse>(BuildSourceInput);
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
        _0 = 0,
        _1 = 1
    }

    public enum imageInput
    {
        _0 = 0,
        _1 = 1
    }

    public enum videoInput
    {
        _0 = 0,
        _1 = 1
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