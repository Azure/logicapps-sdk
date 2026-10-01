//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Omdbip
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class OmdbipActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "omdbip")]
        public IBodyWorkflowAction<GetSearchResultsResponse> GetSearchResults([WorkflowExpression] Func<string> apikey, [WorkflowExpression] Func<string> s = null, [WorkflowExpression] Func<string> i = null, [WorkflowExpression] Func<int> y = null, [WorkflowExpression] Func<typeInput> type = null, [WorkflowExpression] Func<int> page = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["apikey"] = SourceExpressionConverter.ConvertO(apikey);
                if (s != null)
                    callPayload.Queries["s"] = SourceExpressionConverter.ConvertO(s);
                if (i != null)
                    callPayload.Queries["i"] = SourceExpressionConverter.ConvertO(i);
                if (y != null)
                    callPayload.Queries["y"] = SourceExpressionConverter.ConvertO(y);
                if (type != null)
                    callPayload.Queries["type"] = SourceExpressionConverter.Convert(type);
                callPayload.Queries["page"] = Convert.ToString(1);
                if (page != null)
                    callPayload.Queries["page"] = SourceExpressionConverter.ConvertO(page);
                return callPayload;
            }

            return new ApiConnectionAction<GetSearchResultsResponse>(BuildSourceInput);
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