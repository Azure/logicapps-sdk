//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------
namespace Microsoft.Azure.Workflows.Sdk.Connectors.Omdbip
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;
    using System.Linq.Expressions;

    public class OmdbipActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "omdbip")]
        public IBodyWorkflowAction<GetSearchResultsResponse> GetSearchResults(Expression<Func<string>> apikey, Expression<Func<string>> s = null, Expression<Func<string>> i = null, Expression<Func<int>> y = null, Expression<Func<typeInput>> type = null, Expression<Func<int>> page = null)
        {
            var __workflow_apikey = WorkflowExpression.Compile(apikey, nameof(apikey), required: true);
            var __workflow_s = WorkflowExpression.Compile(s, nameof(s), required: false);
            var __workflow_i = WorkflowExpression.Compile(i, nameof(i), required: false);
            var __workflow_y = WorkflowExpression.Compile(y, nameof(y), required: false);
            var __workflow_type = WorkflowExpression.Compile(type, nameof(type), required: false);
            var __workflow_page = WorkflowExpression.Compile(page, nameof(page), required: false);
            return new DeferredBodyAction<GetSearchResultsResponse>(() =>
            {
                var apiCallPath = "/";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["apikey"] = ExpressionConverter.Convert(__workflow_apikey);
                if (__workflow_s != null)
                    callPayload.Queries["s"] = ExpressionConverter.Convert(__workflow_s);
                if (__workflow_i != null)
                    callPayload.Queries["i"] = ExpressionConverter.Convert(__workflow_i);
                if (__workflow_y != null)
                    callPayload.Queries["y"] = ExpressionConverter.Convert(__workflow_y);
                if (__workflow_type != null)
                    callPayload.Queries["type"] = ExpressionConverter.Convert(__workflow_type);
                callPayload.Queries["page"] = Convert.ToString(1);
                if (__workflow_page != null)
                    callPayload.Queries["page"] = ExpressionConverter.Convert(__workflow_page);
                return new ApiConnectionAction<GetSearchResultsResponse>(callPayload);
            });
        }
    }

    public class OmdbipTriggers([ConnectionName] string connectionId)
    {
    }

    public class GetSearchResultsResponse
    {
        public GetSearchResultsResponseSearchTypeItem[] Search { get; set; }
    }

    public class GetSearchResultsResponseSearchTypeItem
    {
        public string Title { get; set; }
        public string Year { get; set; }

        [JsonProperty("imdbID")]
        public string ImdbID { get; set; }
        public string Type { get; set; }
        public string Poster { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum typeInput
    {
        [EnumMember(Value = "movie")]
        Movie,
        [EnumMember(Value = "series")]
        Series,
        [EnumMember(Value = "episode")]
        Episode
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Omdbip;

    public partial class WorkflowManagedActions
    {
        public OmdbipActions Omdbip(string connectionId) => new OmdbipActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public OmdbipTriggers Omdbip(string connectionId) => new OmdbipTriggers(connectionId);
    }
}
