//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------
namespace Microsoft.Azure.Workflows.Sdk.Connectors.Icanhazdadjokeip
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
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
        public IBodyWorkflowAction<SearchForDadJokesResponse> SearchForDadJokes(Expression<Func<int>> page = null, Expression<Func<int>> limit = null, Expression<Func<string>> term = null)
        {
            var __workflow_page = WorkflowExpression.Compile(page, nameof(page), required: false);
            var __workflow_limit = WorkflowExpression.Compile(limit, nameof(limit), required: false);
            var __workflow_term = WorkflowExpression.Compile(term, nameof(term), required: false);
            return new DeferredBodyAction<SearchForDadJokesResponse>(() =>
            {
                var apiCallPath = "/search";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_page != null)
                    callPayload.Queries["page"] = ExpressionConverter.Convert(__workflow_page);
                if (__workflow_limit != null)
                    callPayload.Queries["limit"] = ExpressionConverter.Convert(__workflow_limit);
                if (__workflow_term != null)
                    callPayload.Queries["term"] = ExpressionConverter.Convert(__workflow_term);
                callPayload.Headers["Accept"] = Convert.ToString("application/json");
                return new ApiConnectionAction<SearchForDadJokesResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "icanhazdadjokeip")]
        public IBodyWorkflowAction<FetchaDadJokeResponse> FetchaDadJoke(Expression<Func<string>> jokeid)
        {
            var __workflow_jokeid = WorkflowExpression.Compile(jokeid, nameof(jokeid), required: true);
            return new DeferredBodyAction<FetchaDadJokeResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/j/{0}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_jokeid, 1));
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
