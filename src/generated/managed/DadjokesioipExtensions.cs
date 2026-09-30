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
        public IBodyWorkflowAction<RandomResponse> Random([WorkflowExpression] Func<int> count = null)
        {
            SourceExpression.Validate(count, nameof(count), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/random/joke";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (count != null)
                    callPayload.Queries["count"] = SourceExpressionConverter.ConvertO(count);
                return callPayload;
            }

            return new ApiConnectionAction<RandomResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dadjokesioip")]
        public IBodyWorkflowAction<JokeIdResponse> JokeId([WorkflowExpression] Func<string> id)
        {
            SourceExpression.Validate(id, nameof(id), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/joke/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<JokeIdResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dadjokesioip")]
        public IBodyWorkflowAction<JokeTypeResponse> JokeType([WorkflowExpression] Func<string> type, [WorkflowExpression] Func<int> limit = null)
        {
            SourceExpression.Validate(type, nameof(type), required: true);
            SourceExpression.Validate(limit, nameof(limit), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/joke/type/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(type, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (limit != null)
                    callPayload.Queries["limit"] = SourceExpressionConverter.ConvertO(limit);
                return callPayload;
            }

            return new ApiConnectionAction<JokeTypeResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dadjokesioip")]
        public IBodyWorkflowAction<JokeSearchResponse> JokeSearch([WorkflowExpression] Func<string> term = null)
        {
            SourceExpression.Validate(term, nameof(term), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/joke/search";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (term != null)
                    callPayload.Queries["term"] = SourceExpressionConverter.ConvertO(term);
                return callPayload;
            }

            return new ApiConnectionAction<JokeSearchResponse>(BuildSourceInput);
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

    public class JokeIdResponse
    {
        [JsonProperty("success")]
        public bool Success { get; set; }

        [JsonProperty("body")]
        public JokeIdResponseBodyType Body { get; set; }
    }

    public class JokeIdResponseBodyType
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