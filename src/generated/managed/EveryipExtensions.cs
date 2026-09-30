//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Everyip
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class EveryipActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "everyip")]
        public IBodyWorkflowAction<BrowseResponse> Browse([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> cause, [WorkflowExpression] Func<int> take = null, [WorkflowExpression] Func<int> page = null)
        {
            var apiCallPath = String.Format("/browse/{0}", ExpressionConverter.ConvertWithUrlEncoding(cause, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (take != null)
                callPayload.Queries["take"] = ExpressionConverter.Convert(take);
            if (page != null)
                callPayload.Queries["page"] = ExpressionConverter.Convert(page);
            return new ApiConnectionAction<BrowseResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "everyip")]
        public IBodyWorkflowAction<SearchResponse> Search([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> term, [WorkflowExpression] Func<int> take = null, [WorkflowExpression] Func<string> cause = null)
        {
            var apiCallPath = String.Format("/search/{0}", ExpressionConverter.ConvertWithUrlEncoding(term, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (take != null)
                callPayload.Queries["take"] = ExpressionConverter.Convert(take);
            if (cause != null)
                callPayload.Queries["cause"] = ExpressionConverter.Convert(cause);
            return new ApiConnectionAction<SearchResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "everyip")]
        public IBodyWorkflowAction<DetailsResponse> Details([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> identifier)
        {
            var apiCallPath = String.Format("/nonprofit/{0}", ExpressionConverter.ConvertWithUrlEncoding(identifier, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<DetailsResponse>(callPayload);
        }
    }

    public class EveryipTriggers([ConnectionName] string connectionId)
    {
    }

    public class BrowseResponse
    {
        [JsonProperty("nonprofits")]
        public BrowseResponseNonprofitsTypeItem[] Nonprofits { get; set; }
    }

    public class BrowseResponseNonprofitsTypeItem
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("profileUrl")]
        public string ProfileUrl { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("ein")]
        public string Ein { get; set; }

        [JsonProperty("logoCloudinaryId")]
        public string LogoCloudinaryId { get; set; }

        [JsonProperty("logoUrl")]
        public string LogoUrl { get; set; }

        [JsonProperty("matchedTerms")]
        public string[] MatchedTerms { get; set; }
    }

    public class SearchResponse
    {
        [JsonProperty("nonprofits")]
        public SearchResponseNonprofitsTypeItem[] Nonprofits { get; set; }
    }

    public class SearchResponseNonprofitsTypeItem
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("profileUrl")]
        public string ProfileUrl { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("ein")]
        public string Ein { get; set; }

        [JsonProperty("logoCloudinaryId")]
        public string LogoCloudinaryId { get; set; }

        [JsonProperty("logoUrl")]
        public string LogoUrl { get; set; }

        [JsonProperty("matchedTerms")]
        public string[] MatchedTerms { get; set; }
    }

    public class DetailsResponse
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("profileUrl")]
        public string ProfileUrl { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("ein")]
        public string Ein { get; set; }

        [JsonProperty("logoCloudinaryId")]
        public string LogoCloudinaryId { get; set; }

        [JsonProperty("logoUrl")]
        public string LogoUrl { get; set; }

        [JsonProperty("matchedTerms")]
        public string[] MatchedTerms { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Everyip;

    public partial class WorkflowManagedActions
    {
        public EveryipActions Everyip(string connectionId) => new EveryipActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public EveryipTriggers Everyip(string connectionId) => new EveryipTriggers(connectionId);
    }
}