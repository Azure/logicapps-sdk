//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Lexicaip
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class LexicaipActions([ConnectionName] string connectionId)
    {

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "lexicaip")]
        [WorkflowExpressionFactory(nameof(__BuildSearch))]
        public IBodyWorkflowAction<SearchResponse> Search([WorkflowExpression] Func<string> q)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "lexicaip")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<SearchResponse> __BuildSearch(WorkflowExpression<string> q)
        {
            WorkflowExpression.Validate(q, nameof(q), required: true);
            return new DeferredBodyAction<SearchResponse>(() =>
            {
                var apiCallPath = "/search";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["q"] = ExpressionConverter.Convert(q);
                return new ApiConnectionAction<SearchResponse>(callPayload);
            });
        }
    }

    public class LexicaipTriggers([ConnectionName] string connectionId)
    {
    }

    public class SearchResponse
    {
        [JsonProperty("images")]
        public SearchResponseImagesTypeItem[] Images { get; set; }
    }

    public class SearchResponseImagesTypeItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("gallery")]
        public string Gallery { get; set; }

        [JsonProperty("src")]
        public string Src { get; set; }

        [JsonProperty("srcSmall")]
        public string SrcSmall { get; set; }

        [JsonProperty("prompt")]
        public string Prompt { get; set; }

        [JsonProperty("width")]
        public int Width { get; set; }

        [JsonProperty("height")]
        public int Height { get; set; }

        [JsonProperty("seed")]
        public string Seed { get; set; }

        [JsonProperty("grid")]
        public bool Grid { get; set; }

        [JsonProperty("model")]
        public string Model { get; set; }

        [JsonProperty("guidance")]
        public int Guidance { get; set; }

        [JsonProperty("promptid")]
        public string Promptid { get; set; }

        [JsonProperty("nsfw")]
        public bool Nsfw { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Lexicaip;

    public partial class WorkflowManagedActions
    {
        public LexicaipActions Lexicaip(string connectionId) => new LexicaipActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public LexicaipTriggers Lexicaip(string connectionId) => new LexicaipTriggers(connectionId);
    }
}