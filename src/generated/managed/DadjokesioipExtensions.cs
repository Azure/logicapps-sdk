//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Dadjokesioip
{
        using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class DadjokesioipActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dadjokesioip")]
        [WorkflowExpressionFactory(nameof(__BuildRandom))]
        public IBodyWorkflowAction<RandomResponse> Random([WorkflowExpression] Func<int> count = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<RandomResponse> __BuildRandom(WorkflowValue<int> count = null)
        {
            WorkflowValue.Validate(count, nameof(count), required: false);
            return new DeferredBodyAction<RandomResponse>(() =>
            {
                var apiCallPath = "/random/joke";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (count != null)
                    callPayload.Queries["count"] = ExpressionConverter.Convert(count);
                return new ApiConnectionAction<RandomResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dadjokesioip")]
        [WorkflowExpressionFactory(nameof(__BuildJokeID))]
        public IBodyWorkflowAction<JokeIDResponse> JokeID([WorkflowExpression] Func<string> id)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<JokeIDResponse> __BuildJokeID(WorkflowValue<string> id)
        {
            WorkflowValue.Validate(id, nameof(id), required: true);
            return new DeferredBodyAction<JokeIDResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/joke/{0}", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<JokeIDResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dadjokesioip")]
        [WorkflowExpressionFactory(nameof(__BuildJokeType))]
        public IBodyWorkflowAction<JokeTypeResponse> JokeType([WorkflowExpression] Func<string> type, [WorkflowExpression] Func<int> limit = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<JokeTypeResponse> __BuildJokeType(WorkflowValue<string> type, WorkflowValue<int> limit = null)
        {
            WorkflowValue.Validate(type, nameof(type), required: true);
            WorkflowValue.Validate(limit, nameof(limit), required: false);
            return new DeferredBodyAction<JokeTypeResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/joke/type/{0}", ExpressionConverter.ConvertWithUrlEncoding(type, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (limit != null)
                    callPayload.Queries["limit"] = ExpressionConverter.Convert(limit);
                return new ApiConnectionAction<JokeTypeResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dadjokesioip")]
        [WorkflowExpressionFactory(nameof(__BuildJokeSearch))]
        public IBodyWorkflowAction<JokeSearchResponse> JokeSearch([WorkflowExpression] Func<string> term = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<JokeSearchResponse> __BuildJokeSearch(WorkflowValue<string> term = null)
        {
            WorkflowValue.Validate(term, nameof(term), required: false);
            return new DeferredBodyAction<JokeSearchResponse>(() =>
            {
                var apiCallPath = "/joke/search";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (term != null)
                    callPayload.Queries["term"] = ExpressionConverter.Convert(term);
                return new ApiConnectionAction<JokeSearchResponse>(callPayload);
            });
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

namespace Microsoft.Azure.Workflows.Sdk
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
