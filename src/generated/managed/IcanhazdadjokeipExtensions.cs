//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Icanhazdadjokeip
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class IcanhazdadjokeipActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "icanhazdadjokeip")]
        public IBodyWorkflowAction<FetchRandomJokeResponse> FetchRandomJoke()
        {
            var apiCallPath = "/";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["Accept"] = Convert.ToString("application/json");
            return new ApiConnectionAction<FetchRandomJokeResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "icanhazdadjokeip")]
        [WorkflowExpressionFactory(nameof(__BuildSearchForDadJokes))]
        public IBodyWorkflowAction<SearchForDadJokesResponse> SearchForDadJokes([WorkflowExpression] Func<int> page = null, [WorkflowExpression] Func<int> limit = null, [WorkflowExpression] Func<string> term = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "icanhazdadjokeip")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<SearchForDadJokesResponse> __BuildSearchForDadJokes(WorkflowExpression<int> page = null, WorkflowExpression<int> limit = null, WorkflowExpression<string> term = null)
        {
            WorkflowExpression.Validate(page, nameof(page), required: false);
            WorkflowExpression.Validate(limit, nameof(limit), required: false);
            WorkflowExpression.Validate(term, nameof(term), required: false);
            return new DeferredBodyAction<SearchForDadJokesResponse>(() =>
            {
                var apiCallPath = "/search";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (page != null)
                    callPayload.Queries["page"] = ExpressionConverter.Convert(page);
                if (limit != null)
                    callPayload.Queries["limit"] = ExpressionConverter.Convert(limit);
                if (term != null)
                    callPayload.Queries["term"] = ExpressionConverter.Convert(term);
                callPayload.Headers["Accept"] = Convert.ToString("application/json");
                return new ApiConnectionAction<SearchForDadJokesResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "icanhazdadjokeip")]
        [WorkflowExpressionFactory(nameof(__BuildFetchaDadJoke))]
        public IBodyWorkflowAction<FetchaDadJokeResponse> FetchaDadJoke([WorkflowExpression] Func<string> jokeid)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "icanhazdadjokeip")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<FetchaDadJokeResponse> __BuildFetchaDadJoke(WorkflowExpression<string> jokeid)
        {
            WorkflowExpression.Validate(jokeid, nameof(jokeid), required: true);
            return new DeferredBodyAction<FetchaDadJokeResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/j/{0}", ExpressionConverter.ConvertWithUrlEncoding(jokeid, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Accept"] = Convert.ToString("application/json");
                return new ApiConnectionAction<FetchaDadJokeResponse>(callPayload);
            });
        }
    }

    public class IcanhazdadjokeipTriggers([ConnectionName] string connectionId)
    {
    }

    public class FetchRandomJokeResponse
    {
        [JsonProperty("id")]
        public string JokeID { get; set; }

        [JsonProperty("joke")]
        public string Joke { get; set; }

        [JsonProperty("status")]
        public int Status { get; set; }
    }

    public class SearchForDadJokesResponse
    {
        [JsonProperty("current_page")]
        public int CurrentPage { get; set; }

        [JsonProperty("limit")]
        public int ResultLimit { get; set; }

        [JsonProperty("next_page")]
        public int NextPage { get; set; }

        [JsonProperty("previous_page")]
        public int PreviousPage { get; set; }

        [JsonProperty("results")]
        public SearchForDadJokesResponseResultsTypeItem[] Results { get; set; }

        [JsonProperty("search_term")]
        public string SearchTerm { get; set; }

        [JsonProperty("status")]
        public int Status { get; set; }

        [JsonProperty("total_jokes")]
        public int TotalJokes { get; set; }

        [JsonProperty("total_pages")]
        public int TotalPages { get; set; }
    }

    public class SearchForDadJokesResponseResultsTypeItem
    {
        [JsonProperty("id")]
        public string JokeID { get; set; }

        [JsonProperty("joke")]
        public string Joke { get; set; }
    }

    public class FetchaDadJokeResponse
    {
        [JsonProperty("id")]
        public string JokeID { get; set; }

        [JsonProperty("joke")]
        public string Joke { get; set; }

        [JsonProperty("status")]
        public int Status { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Icanhazdadjokeip;

    public partial class WorkflowManagedActions
    {
        public IcanhazdadjokeipActions Icanhazdadjokeip(string connectionId) => new IcanhazdadjokeipActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public IcanhazdadjokeipTriggers Icanhazdadjokeip(string connectionId) => new IcanhazdadjokeipTriggers(connectionId);
    }
}