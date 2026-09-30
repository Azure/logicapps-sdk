//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Chucknorrisioip
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class ChucknorrisioipActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "chucknorrisioip")]
        public IBodyWorkflowAction<GetRandomChuckNorrisFactResponse> GetRandomChuckNorrisFact([WorkflowExpression] Func<string> category = null)
        {
            var apiCallPath = "/random";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (category != null)
                callPayload.Queries["category"] = ExpressionConverter.Convert(category);
            return new ApiConnectionAction<GetRandomChuckNorrisFactResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "chucknorrisioip")]
        public IBodyWorkflowAction<SearchChuckNorrisFactsResponse> SearchChuckNorrisFacts([WorkflowExpression] Func<string> query)
        {
            var apiCallPath = "/search";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["query"] = ExpressionConverter.Convert(query);
            return new ApiConnectionAction<SearchChuckNorrisFactsResponse>(callPayload);
        }
    }

    public class ChucknorrisioipTriggers([ConnectionName] string connectionId)
    {
    }

    public class GetRandomChuckNorrisFactResponse
    {
        [JsonProperty("icon_url")]
        public string IconURL { get; set; }

        [JsonProperty("id")]
        public string ID { get; set; }

        [JsonProperty("url")]
        public string URL { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class SearchChuckNorrisFactsResponse
    {
        [JsonProperty("total")]
        public int Total { get; set; }

        [JsonProperty("result")]
        public SearchChuckNorrisFactsResponseResultTypeItem[] Result { get; set; }
    }

    public class SearchChuckNorrisFactsResponseResultTypeItem
    {
        [JsonProperty("categories")]
        public JToken[] Categories { get; set; }

        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }

        [JsonProperty("icon_url")]
        public string IconURL { get; set; }

        [JsonProperty("id")]
        public string ID { get; set; }

        [JsonProperty("updated_at")]
        public string UpdatedAt { get; set; }

        [JsonProperty("url")]
        public string URL { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Chucknorrisioip;

    public partial class WorkflowManagedActions
    {
        public ChucknorrisioipActions Chucknorrisioip(string connectionId) => new ChucknorrisioipActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public ChucknorrisioipTriggers Chucknorrisioip(string connectionId) => new ChucknorrisioipTriggers(connectionId);
    }
}