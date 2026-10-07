//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Omdbip
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class OmdbipActions([ConnectionName] string connectionId)
    {

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "omdbip")]
        [WorkflowExpressionFactory(nameof(__BuildGetSearchResults))]
        public IBodyWorkflowAction<GetSearchResultsResponse> GetSearchResults([WorkflowExpression] Func<string> apikey, [WorkflowExpression] Func<string> s = null, [WorkflowExpression] Func<string> i = null, [WorkflowExpression] Func<int> y = null, [WorkflowExpression] Func<typeInput> type = null, [WorkflowExpression] Func<int> page = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "omdbip")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GetSearchResultsResponse> __BuildGetSearchResults(WorkflowExpression<string> apikey, WorkflowExpression<string> s = null, WorkflowExpression<string> i = null, WorkflowExpression<int> y = null, WorkflowExpression<typeInput> type = null, WorkflowExpression<int> page = null)
        {
            WorkflowExpression.Validate(apikey, nameof(apikey), required: true);
            WorkflowExpression.Validate(s, nameof(s), required: false);
            WorkflowExpression.Validate(i, nameof(i), required: false);
            WorkflowExpression.Validate(y, nameof(y), required: false);
            WorkflowExpression.Validate(type, nameof(type), required: false);
            WorkflowExpression.Validate(page, nameof(page), required: false);
            return new DeferredBodyAction<GetSearchResultsResponse>(() =>
            {
                var apiCallPath = "/";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["apikey"] = ExpressionConverter.Convert(apikey);
                if (s != null)
                    callPayload.Queries["s"] = ExpressionConverter.Convert(s);
                if (i != null)
                    callPayload.Queries["i"] = ExpressionConverter.Convert(i);
                if (y != null)
                    callPayload.Queries["y"] = ExpressionConverter.Convert(y);
                if (type != null)
                    callPayload.Queries["type"] = ExpressionConverter.Convert(type);
                callPayload.Queries["page"] = Convert.ToString(1);
                if (page != null)
                    callPayload.Queries["page"] = ExpressionConverter.Convert(page);
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