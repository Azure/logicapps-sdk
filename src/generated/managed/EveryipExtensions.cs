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
        [WorkflowExpressionFactory(nameof(__BuildBrowse))]
        public IBodyWorkflowAction<BrowseResponse> Browse([WorkflowExpression] Func<string> cause, [WorkflowExpression] Func<int> take = null, [WorkflowExpression] Func<int> page = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<BrowseResponse> __BuildBrowse(WorkflowValue<string> cause, WorkflowValue<int> take = null, WorkflowValue<int> page = null)
        {
            WorkflowValue.Validate(cause, nameof(cause), required: true);
            WorkflowValue.Validate(take, nameof(take), required: false);
            WorkflowValue.Validate(page, nameof(page), required: false);
            return new DeferredBodyAction<BrowseResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/browse/{0}", ExpressionConverter.ConvertWithUrlEncoding(cause, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (take != null)
                    callPayload.Queries["take"] = ExpressionConverter.Convert(take);
                if (page != null)
                    callPayload.Queries["page"] = ExpressionConverter.Convert(page);
                return new ApiConnectionAction<BrowseResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "everyip")]
        [WorkflowExpressionFactory(nameof(__BuildSearch))]
        public IBodyWorkflowAction<SearchResponse> Search([WorkflowExpression] Func<string> term, [WorkflowExpression] Func<int> take = null, [WorkflowExpression] Func<string> cause = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<SearchResponse> __BuildSearch(WorkflowValue<string> term, WorkflowValue<int> take = null, WorkflowValue<string> cause = null)
        {
            WorkflowValue.Validate(term, nameof(term), required: true);
            WorkflowValue.Validate(take, nameof(take), required: false);
            WorkflowValue.Validate(cause, nameof(cause), required: false);
            return new DeferredBodyAction<SearchResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/search/{0}", ExpressionConverter.ConvertWithUrlEncoding(term, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (take != null)
                    callPayload.Queries["take"] = ExpressionConverter.Convert(take);
                if (cause != null)
                    callPayload.Queries["cause"] = ExpressionConverter.Convert(cause);
                return new ApiConnectionAction<SearchResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "everyip")]
        [WorkflowExpressionFactory(nameof(__BuildDetails))]
        public IBodyWorkflowAction<DetailsResponse> Details([WorkflowExpression] Func<string> identifier)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<DetailsResponse> __BuildDetails(WorkflowValue<string> identifier)
        {
            WorkflowValue.Validate(identifier, nameof(identifier), required: true);
            return new DeferredBodyAction<DetailsResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/nonprofit/{0}", ExpressionConverter.ConvertWithUrlEncoding(identifier, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<DetailsResponse>(callPayload);
            });
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
