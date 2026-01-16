//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Dadjokesioip
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class DadjokesioipActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dadjokesioip")]
        public IBodyWorkflowAction<RandomResponse> Random(Expression<Func<int>> count = null)
        {
            var apiCallPath = "/random/joke";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (count != null)
                callPayload.Queries["count"] = ExpressionConverter.Convert(count);
            return new ApiConnectionAction<RandomResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dadjokesioip")]
        public IBodyWorkflowAction<JokeIDResponse> JokeID(Expression<Func<string>> id)
        {
            var apiCallPath = String.Format("/joke/{0}", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<JokeIDResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dadjokesioip")]
        public IBodyWorkflowAction<JokeTypeResponse> JokeType(Expression<Func<string>> type, Expression<Func<int>> limit = null)
        {
            var apiCallPath = String.Format("/joke/type/{0}", ExpressionConverter.ConvertWithUrlEncoding(type, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (limit != null)
                callPayload.Queries["limit"] = ExpressionConverter.Convert(limit);
            return new ApiConnectionAction<JokeTypeResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dadjokesioip")]
        public IBodyWorkflowAction<JokeSearchResponse> JokeSearch(Expression<Func<string>> term = null)
        {
            var apiCallPath = "/joke/search";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (term != null)
                callPayload.Queries["term"] = ExpressionConverter.Convert(term);
            return new ApiConnectionAction<JokeSearchResponse>(callPayload);
        }
    }

    public class DadjokesioipTriggers([ConnectionName] string connectionId)
    {
    }

    public class RandomResponse
    {
        [JsonProperty("success")]
        public bool Success { get; set; }

        [JsonProperty("body")]
        public RandomResponseBodyTypeItem[] Body { get; set; }
    }

    public class RandomResponseBodyTypeItem
    {
        [JsonProperty("_id")]
        public string Id { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("setup")]
        public string Setup { get; set; }

        [JsonProperty("punchline")]
        public string Punchline { get; set; }
    }

    public class JokeIDResponse
    {
        [JsonProperty("success")]
        public bool Success { get; set; }

        [JsonProperty("body")]
        public JokeIDResponseBodyType Body { get; set; }
    }

    public class JokeIDResponseBodyType
    {
        [JsonProperty("_id")]
        public string Id { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("setup")]
        public string Setup { get; set; }

        [JsonProperty("punchline")]
        public string Punchline { get; set; }
    }

    public class JokeTypeResponse
    {
        [JsonProperty("success")]
        public bool Success { get; set; }

        [JsonProperty("body")]
        public JokeTypeResponseBodyTypeItem[] Body { get; set; }
    }

    public class JokeTypeResponseBodyTypeItem
    {
        [JsonProperty("_id")]
        public string Id { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("setup")]
        public string Setup { get; set; }

        [JsonProperty("punchline")]
        public string Punchline { get; set; }
    }

    public class JokeSearchResponse
    {
        [JsonProperty("success")]
        public bool Success { get; set; }

        [JsonProperty("body")]
        public JokeSearchResponseBodyTypeItem[] Body { get; set; }
    }

    public class JokeSearchResponseBodyTypeItem
    {
        [JsonProperty("_id")]
        public string Id { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("setup")]
        public string Setup { get; set; }

        [JsonProperty("punchline")]
        public string Punchline { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk.Connectors
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Dadjokesioip;

    public partial class WorkflowManagedActions
    {
        public DadjokesioipActions Dadjokesioip(string connectionId) => new DadjokesioipActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public DadjokesioipTriggers Dadjokesioip(string connectionId) => new DadjokesioipTriggers(connectionId);
    }
}